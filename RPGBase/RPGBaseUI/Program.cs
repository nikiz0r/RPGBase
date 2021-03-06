﻿using RPGBaseLibrary.Base;
using RPGBaseLibrary.Helpers;
using RPGBaseService.Services;
using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPGBaseUI
{
    class Program
    {
        public static readonly MonsterService _monsterService = new MonsterService();
        public static readonly ItemService _itemService = new ItemService();
        public static readonly Events e = new Events();

        static void Main(string[] args)
        {
            var monsterList = _monsterService.getMonsterList();

            //Console.ReadKey();
            // Prologo
            //e.RenderMessage("BLABLABLABLA", new object[] { });
            //e.RenderMessage("BLABLA BLABLA BLABLA", new object[] { }, 2000);
            //e.RenderMessage("BLABLA BLABLA BLABLABLABLA BLABLABLABLABLABLA", new object[] { }, 2000);
            //e.RenderMessage("Now, how should we call you?", new object[] { });

            // Criando o heroi
            //string heroName = e.GetInput();
            var heroName = "Douchebag";

            e.RenderMessage("[Douchebag] is that it?", new object[]{});
            e.GetInput();
            e.RenderMessage("[Douchebag] is really an odd name. Are you really sure?", new object[] { });
            e.GetInput();
            e.RenderMessage("Ok, so we'll call you [Douchebag]. Hurray!", new object[] { });

            Hero hero = new Hero(heroName, 1, 0, 20, 5, 1, 1);
            hero.Equipments.Where(x => x.Slot == (int)SlotEnum.Hand).FirstOrDefault().Item = _itemService.getItem((int)ItemIdEnum.EmptyHands);
            e.RenderMessage("You are playing with {0}, a brave hero who only desires to be a student!", new object[] { hero.Name });

            hero.UpdateStats();

            // Begin treta
            var mob = monsterList[new Random().Next(0, monsterList.Count)];
            var battleResult = Treta(hero, mob);

            // Exemplo de equip
            //hero.EquipItem(_itemService.getItem((int)ItemIdEnum.SilverHelmet));

            Console.ReadKey();
        }

        static int Treta(Hero hero, BaseMonster mob)
        {
            while (hero.CurrentHP > 0 && mob.CurrentHP > 0)
            {
                var input = e.GetInput("\n1- Attack\n2- Defend");

                if (input == "1")
                    hero.Attack(mob);
                else
                    hero.Defend();

                if (mob.CurrentHP > 0)
                    mob.Attack(hero);

                //Events.showStats(hero);
                //Events.showStats(mob);

                if (mob.CurrentHP <= 0)
                {
                    //e.ShowMessage($"{hero.Name} has slain 1 {mob.Name}");
                }
            }

            if (hero.CurrentHP <= 0)
                return -1;
            else
                return 1;
        }
    }
}
