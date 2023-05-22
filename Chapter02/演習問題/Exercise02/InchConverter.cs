using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //フィートとメートル単位変換クラス
    public   class InchConverter {
        private const double retio = 0.0254;

        //インチからフィートを求める
        public static double FromMeter(double meter) {
            return meter / retio;
        }
        //インチからメートルを求める
        public static double ToMeter(double inch) {
            return inch * retio;
        }
    }
}
