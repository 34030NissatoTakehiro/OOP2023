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
        private double moveX = 5;//移動量
        private double moveY = 5;//移動量

        //コンストラクタ
        public SoccerBall() {
            Image = Image.FromFile(@"pic\Soccer_Ball.png");
            posX = 0.0;
            posY = 0.0;
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
