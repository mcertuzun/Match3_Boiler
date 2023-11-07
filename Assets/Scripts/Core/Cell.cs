using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Cell : MonoBehaviour
    {
        private Vector2Int _position;
        private Board _board;
            
        private bool _isFull;
        private List<Cell> _neighbours;

        public void Prepare(Vector2Int position, Board board)
        {
            _position = position;
            _board = board;

            transform.localPosition =new Vector3(position.x,position.y);
            
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawSphere(transform.position, 1);
        }
    }
    

   
}