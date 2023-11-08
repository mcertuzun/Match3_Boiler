﻿using Core;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "BoardData", menuName = "BoardData", order = 0)]
    public class BoardData : ScriptableObject
    {
        public int rowCount;
        public int columnCount;
        public float lenght;
        public Cell cellPrefab;
    }
}