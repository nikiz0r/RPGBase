using RPGBaseLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseLibrary.Base
{
    public class BaseItem
    {
        public BaseItem(int id, int itemRank, string description, int damage, int armor, int slot, double critP)
        {
            this.Id = id;
            this.ItemRank = itemRank;
            this.Description = description;
            this.Damage = damage;
            this.Armor = armor;
            this.Slot = slot;
            this.CritP = critP;
        }

        public int Id { get; set; }
        public int ItemRank { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int Slot { get; set; }
        public double CritP { get; set; }
    }

    public class ItemDrop
    {
        public ItemDrop(int itemId, double itemDropRate)
        {
            this.ItemId = itemId;
            this.ItemDropRate = itemDropRate;
        }

        public int ItemId { get; set; }
        public double ItemDropRate { get; set; }
    }
}
