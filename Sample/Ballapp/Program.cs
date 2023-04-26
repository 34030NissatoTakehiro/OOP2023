﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballapp {
    class Program : Form {

        private Timer moveTimer;
        private Obj obj;
        private PictureBox pb;
        Bar bar;
        PictureBox pbbar;

        private List<Obj> balls = new List<Obj>();//ボール格納
        private List<PictureBox> pbs = new List<PictureBox>();//表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }
        public Program() {
            this.Text = "Ball Game";
            this.Size = new Size(800, 600);
            this.BackColor = Color.Red;

            this.MouseClick += Program_MouseClick;

            this.KeyDown += Program_KeyDown;


            bar = new Bar(350, 500);
            pbbar = new PictureBox();
            pbbar.Image = bar.Image;
            pbbar.Location = new Point((int)bar.PosX, (int)bar.PosY);//画像の位置
            pbbar.Size = new Size(150, 10);
            pbbar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbbar.Parent = this;


            moveTimer = new Timer();
            moveTimer.Interval = 10;//タイマーのインターバル
            moveTimer.Tick += MoveTimer_Tick;//デリゲート登録

        }

        private void Program_KeyDown(object sender, KeyEventArgs e) {

            bar.Move(e.KeyData);
            pbbar.Location = new Point((int)bar.PosX, (int)bar.PosY);//画像の位置

        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            Obj obj = null;
            pb = new PictureBox();







            if (e.Button == MouseButtons.Left)
            {
                this.Text = "Ball Game";
                obj = new SoccerBall(e.X - 25, e.Y - 25);

                pb.Size = new Size(50, 50);//画像の表示サイズ

            }
            else if (e.Button == MouseButtons.Right)
            {

                obj = new Tennisball(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);//画像の表示サイズ

            }


            pb.Image = obj.Image;
            pb.Location = new Point((int)obj.PosX, (int)obj.PosY);//画像の位置   
            pb.SizeMode = PictureBoxSizeMode.StretchImage;//画像の表示サイズ
            pb.Parent = this;
            balls.Add(obj);
            pbs.Add(pb);
            this.Text = "SoccerBall Game" + SoccerBall.Ballcnt + "Tennisball" + Tennisball.Ballcnt;

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
