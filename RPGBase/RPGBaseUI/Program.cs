using RPGBaseLibrary.Base;
using RPGBaseLibrary.Helpers;
using RPGBaseService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseUI
{
    class Program
    {
        public static readonly MonsterService _monsterService = new MonsterService();
        public static readonly ItemService _itemService = new ItemService();

        static void Main(string[] args)
        {
            // Criando o heroi
            Hero hero = new Hero("Charlinho", 1, 0, 20, 5, 1, 1);

            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.Head).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.BronzeHelmet);
            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.OffHand).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.SilverBuckler);

            hero.UpdateStats();

            // Exemplo de equip
            //hero.EquipItem(_itemService.getItem((int)ItemIdEnum.SilverHelmet));


            Console.ReadKey();
        }
    }
}
