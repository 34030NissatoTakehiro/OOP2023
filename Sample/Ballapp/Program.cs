using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballapp {
    class Program : Form {

        private Timer moveTimer;
        private SoccerBall soccerBall ;
        private PictureBox pb;

        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() {
            
            this.Size = new Size(800, 600);
            this.BackColor = Color.Red;
            this.Text = "Ball Game";
            //ボールインスタンス作成

            soccerBall = new SoccerBall();
            pb = new PictureBox();
            pb.Image = soccerBall.Image;
            
            pb.Size = new Size(50, 50);//画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//画像の表示サイズ

            moveTimer = new Timer();
            moveTimer.Interval = 10;//タイマーのインターバル
            moveTimer.Start();//タイマースタート
            moveTimer.Tick += MoveTimer_Tick;


            pb.Parent = this;

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            soccerBall.Move();//移動
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);//画像の位置
        }
    }
}
