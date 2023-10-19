using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02.ConcreteConverter {
    public class KilometerComberte : Framework.ConverterBase {
        public override bool IsMyUnit(string name) {
            return name.ToLower() == "キロメーター" || name == UnitName;
        }
        protected override double Ratio { get { return 1000; } }
        public override string UnitName { get { return "キロメーター"; } }
    }
}
