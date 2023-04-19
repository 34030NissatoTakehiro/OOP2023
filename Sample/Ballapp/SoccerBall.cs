using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballapp {
    class SoccerBall {
        //  フィールド
        private Image image;//画像データ

        private double posX;//x座標
        private double posY;//y座標
        private double moveX ;//移動量
        private double moveY ;//移動量
        

        //コンストラクタ
        public SoccerBall(double xp,double yp) {
            Image = Image.FromFile(@"pic\Soccer_Ball.png");
            posX = xp;
            posY = yp;

            Random rand = new Random();

            int randomX = rand.Next(1, 100);
            moveX = (randomX != 0 ? randomX : 1);
            
            int rondomY= rand.Next(1, 100);
            moveY = (rondomY != 0 ? rondomY : 1);

        }
        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソット
        public void Move() {
            if (posY > 550 ||posY <0)
            {
                moveY = -moveY;
                
            }
            if (posX > 750 || posX < 0)
            {
                moveX = -moveX;

            }




            posX = posX + moveX;
            posY = posY + moveY;
        }
    }
}
