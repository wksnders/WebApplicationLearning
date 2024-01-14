using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace BlazorApp2.Models
{
    public class GameOfLifeModel
    {
        public int Rows {get; private set; }
        public int Columns { get; private set; }

        public bool[,] Grid { get; set; } //rows,col

        public GameOfLifeModel(int rows,int columns) 
        {
            Rows = rows;
            Columns = columns;
            Grid = new bool[rows, columns];
        }

        public void RandomizeGrid()
        {
            for (var row = 0; row < Rows; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    Grid[row, column] = RandomNumberGenerator.GetInt32(0, 2) == 0;
                }
            }
        }

        public void NextGeneration()
        {
            bool[,] nextGrid = new bool[Rows, Columns];

            int[] CurrentRowCounts = new int[Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int liveNeighbors = CountLiveNeighbors(i, j);

                    // Conway's Game of Life rules
                    nextGrid[i, j] = (liveNeighbors == 3) || (liveNeighbors == 2 && Grid[i, j]);
                }
            }

            Grid = nextGrid;
        }

        private int CountLiveNeighbors(int row, int col)
        {
            int liveNeighbors = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int newRow = row + i;
                    int newCol = col + j;

                    // Check boundaries and treat any spot off the grid as false
                    if (newRow >= 0 && newRow < Rows && newCol >= 0 && newCol < Columns)
                    {
                        liveNeighbors += Grid[newRow, newCol] ? 1 : 0;
                    }
                }
            }

            return liveNeighbors;
        }

        public void ToggleStatus(int row, int column)
        {
            Grid[row, column] = !Grid[row, column];
        }
    }
}
