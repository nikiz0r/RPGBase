using RPGBaseData.Data;
using RPGBaseLibrary.Base;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RPGBaseRepository.Repositories
{
    public class ItemRepository
    {
        public readonly ItemData _itemData = new ItemData();
        
        public List<BaseItem> getItemList(int itemRank = 0)
        {
            List<BaseItem> itemList = _itemData.loadItems();

            if (itemRank > 0)
                itemList = itemList.Where(x => x.ItemRank == itemRank).ToList();

            return itemList;
        }

        public BaseItem getItem(int itemId)
        {
            return _itemData.loadItems().Where(x => x.Id == itemId).FirstOrDefault();
        }
    }
}
