using System;
using System.Collections.Generic;
using Data;
using UnityEngine;

namespace Core
{
    public class Board : MonoBehaviour
    {
        private readonly Cell[,] Cells;
        [SerializeField] private readonly BoardData boardData;
        public Board()
        {
            
        }

        public void PrepareLevel()
        {
            for (int y = 0; y < boardData.rowCount;y++)
            {
                for (int x = 0; x < boardData.columnCount; x++)
                {
                    Cells[x, y].Prepare(new Vector2Int(x,y), this);
                }
            }
        }
    }
    
    
}