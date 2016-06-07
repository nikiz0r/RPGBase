using RPGBaseLibrary.Base;
using RPGBaseLibrary.Helpers;
using RPGBaseService.Services;
using System;
using System.Linq;
using System.Text;

namespace RPGBaseUI
{
    class Program
    {
        public static readonly MonsterService _monsterService = new MonsterService();
        public static readonly ItemService _itemService = new ItemService();
        public static readonly Events e = new Events();

        static void Main(string[] args)
        {
            // Criando o heroi
            Hero hero = new Hero("Charlinho", 1, 0, 20, 5, 1, 1);

            e.RenderMessage("You are playing with % s, a brave hero who only desires to be a student!", new object[] { hero.Name });

            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.Hand).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.BronzeSword);
            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.Head).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.BronzeHelmet);
            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.OffHand).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.SilverBuckler);

            //hero.UpdateStats();

            // Exemplo de equip
            //hero.EquipItem(_itemService.getItem((int)ItemIdEnum.SilverHelmet));

            Console.ReadKey();
        }
    }
}
