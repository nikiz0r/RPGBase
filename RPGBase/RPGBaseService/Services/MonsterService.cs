using RPGBaseLibrary.Base;
using RPGBaseRepository.Repositories;
using System;
using System.Collections.Generic;

namespace RPGBaseService.Services
{
    public class MonsterService
    {
        private readonly MonsterRepository _monsterRepository = new MonsterRepository();

        public List<BaseMonster> getMonsterList()
        {
            return _monsterRepository.getMonsterList();
        }

        public BaseMonster getMonster(int monsterId)
        {
            return _monsterRepository.getMonster(monsterId);
        }
    }
}
