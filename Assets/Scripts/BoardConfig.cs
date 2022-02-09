using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class BoardConfig : ScriptableObject
    {
        private Cell[,] boardCells;
        [SerializeField] private GameObject boardPrefab;
        [SerializeField] private int boardSize;
        [SerializeField] private int boardStep;




        public void InitCells()
        {
            Instantiate(boardPrefab);
            boardCells = new Cell[boardSize,boardSize];
            for (int i = 0; i < boardSize; i+=boardStep)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardCells[i,j] = new Cell(i, j, "");
                }
            }
        }

        public void SetFigureState(int x, int y, string name)
        {
            boardCells[x, y].name = name;
        }
        
    }
    

    struct Cell
    {
        private int xPos;
        private int yPos;
        
        public string name;

        public Cell(int xPos, int yPos, string name)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.name = name;
            
        }
    }
}