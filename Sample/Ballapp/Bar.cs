using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballapp {
    class Bar:Obj{
            public Bar(double xp, double yp)
               : base(xp, yp, @"pic\bar.png") {
            MoveX = 10;
            MoveY = 0;

        }

         public override void Move() {
            ;
        }

        public  void Move(Keys direction) {
            if (direction == Keys.Right)
            {
                PosX += MoveX;

            }
            else if(direction == Keys.Left)
            {
                PosX -= MoveX;
            }
        }
          
    }
}
