using RPGBaseLibrary.Helpers;
using System;
using System.Collections.Generic;

namespace RPGBaseLibrary.Base
{
    public class BaseMonster : BaseCharacter
    {
        private readonly Events e = new Events();

        public BaseMonster(int id, string name, int level, int experience, int HP, int MP, int baseDamage, int baseArmor, double enrageHPPerc, double dropRate, List<ItemDrop> droppableItems)
            : base(id, name, level, experience, HP, MP, baseDamage, baseArmor)
        {
            this.DropRate = dropRate;
            this.DropItems = droppableItems;
            this.EnrageHPPerc = enrageHPPerc;
        }

        public double DropRate { get; set; }
        public List<ItemDrop> DropItems { get; set; }
        public double EnrageHPPerc { get; set; }

        public void Attack(BaseCharacter target)
        {
            int targetArmor = target.Armor;
            int resultDamage = this.Damage;

            // raise targets armor if it is defending
            if (target.Stance == (int)StanceEnum.Defense)
                targetArmor *= 2;

            // changes self stance only if it was defending before
            if (this.Stance == (int)StanceEnum.Defense)
                e.StanceChange(this, StanceEnum.Attack);

            // checks if self is enraged
            if (this.CurrentHP <= this.MaxHP * this.EnrageHPPerc)
            {
                e.RenderMessage("{0} is enraged. (Causes double damage)", new object[] { this.Name });
                resultDamage *= (int)AttackModifierEnum.CriticalHit;
            }

            resultDamage = resultDamage > targetArmor ? resultDamage - targetArmor : 0;
            target.CurrentHP -= resultDamage;

            e.RenderMessage("{0} attacks {1}.", new object[] { this.Name, target.Name });
            if (resultDamage == 0)
                e.RenderMessage("{0} armor is too high ({1}), {2} dealt no damage at all!", new object[] { target.Name, target.Armor, this.Name });
            else
                e.RenderMessage("{0} deals {1} damage to {2}.", new object[] { this.Name, resultDamage, target.Name });
        }

        public void Defend()
        {
            if (this.Stance == (int)StanceEnum.Defense)
                e.RenderMessage("{0} continues defending himself.", new object[] { this.Name });
            else
                e.StanceChange(this, StanceEnum.Defense);
        }
    }
}
