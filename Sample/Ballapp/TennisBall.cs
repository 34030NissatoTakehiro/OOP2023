using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballapp {
    class Tennisball : Obj {
        private static int ballcnt;
        public static int Ballcnt { get => ballcnt; set => ballcnt = value; }

        public Tennisball(double xp, double yp)
           : base(xp, yp, @"pic\tennis_Ball.png") {

           
            Random rand = new Random();

            int randomX = rand.Next(1, 100);
            MoveX = (randomX != 0 ? randomX : 1);

            int rondomY = rand.Next(1, 100);
            MoveY = (rondomY != 0 ? rondomY : 1);
            Ballcnt++;
        }

       

        public override void Move() {
            if (PosY > 550 || PosY < 0)
            {
                MoveY = -MoveY;

            }
            if (PosX > 750 || PosX < 0)
            {
                MoveX = -MoveX;

            }




            PosX = PosX + MoveX;
            PosY = PosY + MoveY;
        }
        
        }
}
