using System;

namespace BlazorApp2.Models.ComponentModels
{
    public class Carousel
    {
        public int ActiveIndex { get; private set; }
        public int NumPages = -1;
        Action? OnUpdateIndex;

        public Carousel(int pages,Action onUpdateIndex) {
            ActiveIndex = 0;
            NumPages = pages;
            OnUpdateIndex = onUpdateIndex;
        }

        public void SetCaroselIndex(int newIndex)
        {
            if (NumPages <= 0)
            {
                return;
            }
            if (newIndex >= NumPages)
            {
                newIndex = NumPages - 1;
            }
            else if (newIndex < 0)
            {
                newIndex = 0;
            }

            ActiveIndex = newIndex;
            OnUpdateIndex?.Invoke();
        }
    }
}
