namespace BlazorApp2.Models
{
    public struct ActionWithCost
    {
        public double cost;
        public Action action;
    }

    public struct CounterAutoClickerItem {
        public double autoClickerValue;
    }
    public struct CounterItemIcons
    {
        public string IconPathEnabled;
        public string IconPathDisabled;
    }
    public class CounterGameModel
    {
        public static CounterGameModel Instance {
            get {
                if (inst is null) {
                    inst = new CounterGameModel();
                }
                return inst;
            }
        }
        private static CounterGameModel? inst;

        private static readonly Dictionary<CounterItemType, CounterAutoClickerItem> AutoClickerItems = new Dictionary<CounterItemType, CounterAutoClickerItem>
        {
            {  CounterItemType.AutoClicker,
                new CounterAutoClickerItem{
                    autoClickerValue = 0.01
                }
            }
        };

        private static readonly Dictionary<CounterItemType, CounterItemIcons> ItemIcons = new Dictionary<CounterItemType, CounterItemIcons>
        {
            {  CounterItemType.IncreasePlayerClickValue,
                new CounterItemIcons{
                    IconPathEnabled = "ClickerGameComponents/IncreasePlayerClickValue.svg",
                    IconPathDisabled = "ClickerGameComponents/IncreasePlayerClickValue.svg"
                }
            },
            {  CounterItemType.AutoClicker,
                new CounterItemIcons{
                    IconPathEnabled = "ClickerGameComponents/AutoClickerIconClick.svg",
                    IconPathDisabled = "ClickerGameComponents/AutoClickerIconWait.svg"
                }
            }
        };
                  


        double gameTickSpeed = 100000; //time between frames in microseconds

        bool gameIsRunning;
        public int DisplayCount
        {
            get { return (int)(Math.Floor(currentCount)); }
            private set { currentCount = (double)value; }
        }
        public double currentCount = 0;
        public double PlayerClickValue { get; set; } = 1;
        public double PlayerClickValueIncreaseAmount { get; set; } = 1;
        public double autoIncrementAmount { get; set; } = 0;
        PeriodicTimer gameLoopTimer;

        Queue<ActionWithCost> playerInputs = new Queue<ActionWithCost>();
        public List<Action> lateUpdateActions = new List<Action>();

        public CounterGameModel()
        {
            gameLoopTimer = new PeriodicTimer(TimeSpan.FromMicroseconds(gameTickSpeed));
        }

        public void StartGame()
        {
            gameIsRunning = true;
            _ = GameLoopAsync(gameLoopTimer);
        }

        public void PauseUnpause() {
            gameIsRunning = !gameIsRunning;
        }

        public void PlayerClicked()
        {
            currentCount += PlayerClickValue;
        }

        public void PlayerGotItem(CounterItemType type) {
            if (type == CounterItemType.None) {
                return;
            }
            //TODO notify view that player got Item

            if (type == CounterItemType.IncreasePlayerClickValue) {
                PlayerClickValue += PlayerClickValueIncreaseAmount;
                return;
            }

            if (AutoClickerItems.ContainsKey(type))
            {
                autoIncrementAmount += AutoClickerItems[type].autoClickerValue;
                return;
            }
        }

        public void EnqueuePlayerAction(ActionWithCost action) {
            playerInputs.Enqueue(action);
        }

        private bool TryMakePurchaseWithCost(double Cost)
        {
            //Cost = Math.Floor(Cost);
            if (currentCount < Cost)
            {
                return false;
            }
            currentCount -= Cost;
            return true;
        }

        private async Task GameLoopAsync(PeriodicTimer timer)
        {
            while (gameIsRunning)
            {
                await timer.WaitForNextTickAsync();
                Update();

                LateUpdate();
            }
        }

        private void Update()
        {
            while (playerInputs.Count > 0)
            {
                //dequeue player actions and apply effects of those actions
                ActionWithCost actionWithCost = playerInputs.Dequeue();
                if (TryMakePurchaseWithCost(actionWithCost.cost))
                {
                    actionWithCost.action?.Invoke();
                }
            }

            currentCount += autoIncrementAmount;

        }

        private void LateUpdate()
        {
            foreach (Action action in lateUpdateActions)
            {
                action?.Invoke();
            }
        }

        public CounterItemIcons GetItemIcons(CounterItemType type) {
            return ItemIcons[type];
        }
    }
    public class CounterShopItem
    {
        public string? Name;
        public bool IsLocked;
        public double Cost;
        public double CostIncreaseFactor;
    }


    public enum CounterItemType{ 
        None,
        IncreasePlayerClickValue,
        AutoClicker
        
    }
    public class CounterGameShopModel
    {
        public Dictionary<CounterItemType, CounterShopItem> shopItems { get; private set; }
        public CounterGameShopModel(Dictionary<CounterItemType, CounterShopItem> initialShopItems) {
            shopItems = initialShopItems;
        }

        public bool TryBuyShopItem(Action<CounterItemType> playerGotItem,CounterItemType type,out ActionWithCost action) 
        {
            CounterShopItem item;
            if (!shopItems.TryGetValue(type,out item) || item.IsLocked) {
                action = new ActionWithCost{ };
                return false;
            }
            
            item.IsLocked = true;
            action = new ActionWithCost
            {
                cost = item.Cost,
                action = () => {
                    playerGotItem(type);
                    item.Cost = item.Cost * item.CostIncreaseFactor;
                    item.IsLocked = false;
                }
            };
            return true;
        }
    }
}
