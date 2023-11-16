using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
   public class WeightgramUnit:DistanceUnit {
        private static List<WeightgramUnit> units = new List<WeightgramUnit> {
           new WeightgramUnit{Name="g",Coefficient=1,},
            new WeightgramUnit{Name="kg",Coefficient=1*1000,},
        };
        public static ICollection<WeightgramUnit> Units { get { return units; } }

        /// <summary>
        /// ポンド単位からグラム単位に変換
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <return>メートル単位</return>
        public double FromWeightpondUnit(WeightpondUnit unit, double value) {
            return (value * unit.Coefficient) * 28.35 / this.Coefficient;
        }
    }
}
