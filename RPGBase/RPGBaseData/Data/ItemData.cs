using RPGBaseLibrary.Base;
using RPGBaseLibrary.Helpers;
using System;
using System.Collections.Generic;

namespace RPGBaseData.Data
{
    public class ItemData
    {
        private List<BaseItem> itemList = new List<BaseItem>();

        public List<BaseItem> loadItems()
        {
            itemList.Add(new BaseItem(0, 0, "Empty Hands", 1, 0, (int)SlotEnum.Hand, 0));
            itemList.Add(new BaseItem(1, 1, "Bronze Sword", 4, 0, (int)SlotEnum.Hand, 0.1));
            itemList.Add(new BaseItem(2, 1, "Bronze Helmet", 0, 1, (int)SlotEnum.Head, 0));
            itemList.Add(new BaseItem(3, 1, "Bronze Armor", 0, 2, (int)SlotEnum.Chest, 0));
            itemList.Add(new BaseItem(4, 1, "Bronze Greaves", 0, 1, (int)SlotEnum.Feet, 0));
            itemList.Add(new BaseItem(5, 1, "Bronze Buckler", 0, 3, (int)SlotEnum.OffHand, 0));
            itemList.Add(new BaseItem(6, 2, "Silver Sword", 10, 0, (int)SlotEnum.Hand, 0.2));

            return itemList;
        }
    }
}
