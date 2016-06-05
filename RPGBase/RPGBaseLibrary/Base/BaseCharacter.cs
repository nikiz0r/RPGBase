using RPGBaseLibrary.Helpers;
using System;

namespace RPGBaseLibrary.Base
{
    public class BaseCharacter
    {
        public BaseCharacter(int id, string name, int level, int experience, int HP, int MP, int baseDamage, int baseArmor)
        {
            this.Id = id;
            this.Name = name;
            this.Level = level;
            this.Experience = experience;
            this.MaxHP = HP;
            this.MaxMP = MP;
            this.BaseDamage = baseDamage;
            this.BaseArmor = baseArmor;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int MaxMP { get; set; }
        public int CurrentMP { get; set; }
        public int BaseDamage { get; set; }
        public int Damage { get; set; }
        public int BaseArmor { get; set; }
        public int Armor { get; set; }
        public StanceEnum Stance { get; set; }
    }
}
