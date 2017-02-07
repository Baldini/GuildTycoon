using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Models;

namespace Assets.Scripts
{
    public class HeroModel : Stats
    {
        public string Name { get; set; }
        public EnumClass Class { get; set; }

        #region Level
        public int Level { get; set; }
        public int CurrentXp { get; set; }
        public int NextLvl { get; set; }
        public int VariationPoints { get; set; }
        #endregion

        #region External Points
        public List<string> Skills { get; set; }
        public List<EquipModel> Equips { get; set; }
        #endregion

        #region Methods
        public void LevelUp()
        {
            var XP = CurrentXp - NextLvl;
            if (XP >= 0)
            {
                CurrentXp = 0 + XP;
                Level += 1;
                UpgradeStats();
            }
        }
        public void UpgradeStats()
        {
            Strength += Strength * VariationPoints;
            Agility += Agility * VariationPoints;
            Vitality += Vitality * VariationPoints;
            Inteligence += Inteligence * VariationPoints;
            Armor += (Vitality + Strength) * VariationPoints;
            MagicDefense = (Vitality + Inteligence) * VariationPoints;
            LifePoints += (Vitality + (Strength / 2) + (Agility / 2) + (Inteligence / 2)) * VariationPoints;
        }
        public void setDamage(EnumDamage type, int Damage)
        {
            switch (type)
            {
                case EnumDamage.Physical:
                    LifePoints -= Damage * (-1 * Armor);
                    break;
                case EnumDamage.Magic:
                    LifePoints -= Damage * (-1 * MagicDefense);
                    break;
            }
        }
        public int getDamage()
        {
            return Strength;
        }
        public void setEquip(EquipModel equip)
        {
            Strength += equip.Strength;
            Inteligence += equip.Inteligence;
            Agility += equip.Agility;
            Vitality += equip.Vitality;
            Armor += equip.Armor;
            MagicDefense += equip.MagicDefense;

            Equips.Add(equip);
        }
        public void removeEquip(EquipModel equip)
        {
            Strength -= equip.Strength;
            Inteligence -= equip.Inteligence;
            Agility -= equip.Agility;
            Vitality -= equip.Vitality;
            Armor -= equip.Armor;
            MagicDefense -= equip.MagicDefense;

            Equips.Remove(equip);
        }
        #endregion
    }
}
