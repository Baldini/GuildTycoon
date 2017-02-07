using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Models
{
    public class Stats
    {
        #region Stats
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public int Inteligence { get; set; }

        #region Fixed Stats
        public int LifePoints { get; set; }
        public int Armor { get; set; }
        public int MagicDefense { get; set; }
        #endregion

        #endregion
    }
}
