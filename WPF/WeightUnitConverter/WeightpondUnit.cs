using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
   public class WeightpondUnit :DistanceUnit {
        private static List<WeightpondUnit> units = new List<WeightpondUnit> {
            new WeightpondUnit{Name="lb",Coefficient=1,},
            new WeightpondUnit{Name="oz",Coefficient=1/16,},
        };
        public static ICollection<WeightpondUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <return>メートル単位</return>
        public double FromWeightgramUnit(WeightgramUnit unit, double value) {
            return (value * unit.Coefficient) / 28.35 / this.Coefficient;
        }
    }
}
