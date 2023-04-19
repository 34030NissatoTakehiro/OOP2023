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
        private List<SoccerBall> balls = new List<SoccerBall>();//ボール格納
        private List<PictureBox> pbs = new List<PictureBox>();//表示用


        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() {
            
            this.Size = new Size(800, 600);
            this.BackColor = Color.Red;
            this.Text = "Ball Game";
            this.MouseClick += Program_MouseClick;
            //ボールインスタンス作成

            

            moveTimer = new Timer();
            moveTimer.Interval = 10;//タイマーのインターバル
            moveTimer.Tick += MoveTimer_Tick;//デリゲート登録

        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {

            soccerBall = new SoccerBall(e.X -25,e.Y - 25);
            pb = new PictureBox();
            pb.Image = soccerBall.Image;

            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);//画像の位置
            pb.Size = new Size(50, 50);//画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//画像の表示サイズ
            pb.Parent = this;
            balls.Add(soccerBall);
            pbs.Add(pb);

            moveTimer.Start();//タイマースタート
        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();//移動
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);//画像の位置
            }
            
           
        }
    }
}
