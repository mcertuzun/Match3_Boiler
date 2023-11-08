using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Core
{
    public class Cell : MonoBehaviour
    {
        [HideInInspector] public int X;
        [HideInInspector] public int Y;

        private Board _board;
        private bool _isFull;
        public List<Cell> Neighbours { get; private set; }
        [HideInInspector] public Cell FirstCellBelow;


        public TextMesh LabelText;


        public void Prepare(int x, int y, Board board)
        {
            X = x;
            Y = y;
            transform.localPosition = new Vector3(x, y);
            _board = board;
            UpdateNeighbours(_board);
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            var cellName = X + ":" + Y;
            LabelText.text = cellName;
            gameObject.name = "Cell " + cellName;
        }

        private void UpdateNeighbours(Board board)
        {
            Neighbours = new List<Cell>();
            var up = board.GetNeighbourWithDirection(this, Direction.Up);
            var down = board.GetNeighbourWithDirection(this, Direction.Down);
            var left = board.GetNeighbourWithDirection(this, Direction.Left);
            var right = board.GetNeighbourWithDirection(this, Direction.Right);

            if (up != null) Neighbours.Add(up);
            if (down != null) Neighbours.Add(down);
            if (left != null) Neighbours.Add(left);
            if (right != null) Neighbours.Add(right);

            if (down != null) FirstCellBelow = down;
        }

        private void OnDrawGizmos()
        {
           // Handles.color = Color.red;
            //Handles.DrawSolidDisc(transform.position, transform.forward, 0.1f);
        }
    }
}