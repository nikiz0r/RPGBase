using RPGBaseData.Data;
using RPGBaseLibrary.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGBaseRepository.Repositories
{
    public class MonsterRepository
    {
        public readonly MonsterData _monsterData = new MonsterData();

        public List<BaseMonster> getMonsterList()
        {
            return _monsterData.loadMonsters();
        }

        public BaseMonster getMonster(int monsterId)
        {
            return _monsterData.loadMonsters().Where(x => x.Id == monsterId).FirstOrDefault();
        }
    }
}
