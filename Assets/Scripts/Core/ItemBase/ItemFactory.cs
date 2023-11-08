using Items;
using UnityEngine;

namespace Core.ItemBase
{
       public static class ItemFactory
    {
        private static GameObject _itemBasePrefab;

        public static Item CreateItem(ItemType itemType, Transform parent)
        {
            if (_itemBasePrefab == null)
            {
                _itemBasePrefab = Resources.Load("ItemBase") as GameObject;
            }
            
            var itemBase = GameObject.Instantiate(
                _itemBasePrefab, Vector3.zero, Quaternion.identity, parent).GetComponent<ItemBase>();
            
            Item item = null;
            switch (itemType)
            {
                case ItemType.GreenCube:
                    item = CreateCubeItem(itemBase, MatchType.Green);
                    break;
                case ItemType.YellowCube:
                    item = CreateCubeItem(itemBase, MatchType.Yellow);
                    break;
                case ItemType.BlueCube:
                    item = CreateCubeItem(itemBase, MatchType.Blue);
                    break;
                case ItemType.RedCube:
                    item = CreateCubeItem(itemBase, MatchType.Red);
                    break;    
               
                default:
                    Debug.LogWarning("Can not create item: " + itemType);
                    break;
            }
            
            return item;
        }

        private static Item CreateCubeItem(ItemBase itemBase, MatchType matchType)
        {
            var cubeItem = itemBase.gameObject.AddComponent<CubeItem>();
            cubeItem.PrepareCubeItem(itemBase, matchType);
            
            return cubeItem;
        }
    

    }
       public enum ItemType
       {
           None = 0,
           GreenCube = 1,
           YellowCube = 2,
           BlueCube = 3,
           RedCube = 4,
         
       }
       
       public enum MatchType
       {
           None = 0,
           Green = 1,
           Yellow = 2,
           Blue = 3,
           Red = 4,
           Special = 5
       }
}