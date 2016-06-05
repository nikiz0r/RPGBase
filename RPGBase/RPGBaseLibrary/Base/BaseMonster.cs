using System;
using System.Collections.Generic;

namespace RPGBaseLibrary.Base
{
    public class BaseMonster : BaseCharacter
    {
        public BaseMonster(int id, string name, int level, int experience, int HP, int MP, int baseDamage, int baseArmor, double dropRate, List<ItemDrop> droppableItems)
            : base(id, name, level, experience, HP, MP, baseDamage, baseArmor)
        {
            this.DropRate = dropRate;
            this.DropItems = droppableItems;
        }

        public double DropRate { get; set; }
        public List<ItemDrop> DropItems { get; set; }
    }
}
