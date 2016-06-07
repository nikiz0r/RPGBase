using RPGBaseLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGBaseLibrary.Base
{
    public class Hero : BaseCharacter
    {
        private readonly Events e = new Events();

        public Hero(string name, int level, int experience, int HP, int MP, int baseDamage, int baseArmor)
            : base(0, name, level, experience, HP, MP, baseDamage, baseArmor)
        {
            Damage = BaseDamage;
            Armor = BaseArmor;
            CurrentHP = MaxHP;
            CurrentMP = MaxMP;

            Equipments = new List<Equipment>{
                new Equipment((int)SlotEnum.Head),
                new Equipment((int)SlotEnum.Chest),
                new Equipment((int)SlotEnum.Hand),
                new Equipment((int)SlotEnum.OffHand),
                new Equipment((int)SlotEnum.Feet)
            };
        }

        public List<Equipment> Equipments { get; set; }

        public bool EquipItem(BaseItem item)
        {
            bool playerDecision = false;
            bool choice = false;

            while (!playerDecision)
            {
                // Verifica se ja existe item equipado no slot referente ao item obtido
                BaseItem equippedItem = this.Equipments.Where(x => x.Slot == item.Slot).FirstOrDefault().Item;
                if (equippedItem != null)
                {
                    Console.WriteLine(string.Format("Would you like to switch [{0}] for [{1}]?\nY or N", equippedItem.Description, item.Description));
                    choice = e.getInput() == "Y";

                    Console.WriteLine(string.Format("Do you really want to discard [{0}]?\nY or N", choice ? equippedItem.Description : item.Description));
                    playerDecision = e.getInput() == "Y";
                }
                else
                {
                    Console.WriteLine(string.Format("Would you like to equip [{0}]?\nY or N", item.Description));
                    choice = e.getInput() == "Y";

                    if (!choice)
                    {
                        Console.WriteLine(string.Format("Do you really want to discard [{0}]?\nY or N", item.Description));
                        playerDecision = e.getInput() == "Y";
                    }
                    else
                        playerDecision = true;
                }
            }

            if (choice)
                this.Equipments.Where(x => x.Slot == item.Slot).FirstOrDefault().Item = item;

            return choice;
        }

        public void UpdateStats()
        {
            int totalDamage = this.BaseDamage;
            int totalArmor = this.BaseArmor;

            foreach (var equip in this.Equipments)
            {
                if (equip.Item != null)
                {
                    totalArmor += equip.Item.Armor;
                    totalDamage += equip.Item.Damage;
                }
            }

            this.Armor = totalArmor;
            this.Damage = totalDamage;
        }
    }

    public class Equipment
    {
        public Equipment(int slot, BaseItem item = null)
        {
            this.Slot = slot;

            if (item != null)
                this.Item = item;
        }

        public int Slot { get; set; }
        public BaseItem Item { get; set; }
    }
}
