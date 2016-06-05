using RPGBaseLibrary.Base;
using RPGBaseLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseData.Data
{
    public class MonsterData
    {
        private List<BaseMonster> monsterList = new List<BaseMonster>();

        public List<BaseMonster> loadMonsters()
        {
            monsterList.Add(new BaseMonster(1, "Skeleton", 1, 10, 5, 0, 3, 0, 0.3,
                new List<ItemDrop>{ new ItemDrop((int)ItemIdEnum.BronzeSword, 0.1),
                                    new ItemDrop((int)ItemIdEnum.BronzeHelmet, 0.1)}));

            monsterList.Add(new BaseMonster(2, "Gargoyle", 1, 15, 10, 0, 5, 1, 0.2,
                new List<ItemDrop>{ new ItemDrop((int)ItemIdEnum.BronzeBuckler, 0.1),
                                    new ItemDrop((int)ItemIdEnum.BronzeHelmet, 0.3)}));

            return monsterList;
        }
    }
}
