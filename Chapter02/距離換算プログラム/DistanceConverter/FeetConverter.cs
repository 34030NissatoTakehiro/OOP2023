using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートル単位変換クラス
    public   class FeetConverter {
        private const double resio = 0.3048;

        //メートルからフィートを求める
        public static double FromMeter(double meter) {
            return meter / resio;
        }
        //フィートからメートルを求める
        public static double ToMeter(double feet) {
            return feet * resio;
        }
    }
}
