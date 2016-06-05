using RPGBaseLibrary.Base;
using RPGBaseRepository.Repositories;
using System;
using System.Collections.Generic;

namespace RPGBaseService.Services
{
    public class ItemService
    {
        private readonly ItemRepository _itemRepository = new ItemRepository();

        public List<BaseItem> getItemList(int itemRank = 0)
        {
            return _itemRepository.getItemList(itemRank);
        }

        public BaseItem getItem(int itemId)
        {
            return _itemRepository.getItem(itemId);
        }
    }
}
