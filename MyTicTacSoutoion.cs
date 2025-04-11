using MyFirstWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class MyTicTacSoutoion : Form
    {
        public MyTicTacSoutoion()
        {
            InitializeComponent();
        }


        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(255, 255, 255, 255); // ARGB format

            Pen pen = new Pen(color, 10); // Create a pen with the specified color and width

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; // Set the start cap to round
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round; // Set the start cap to round
            e.Graphics.DrawLine(pen, 400, 460, 1000, 460);
            e.Graphics.DrawLine(pen, 400, 260, 1000, 260);
            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 810, 140, 810, 620);
        }


        private void setXOImageAndTag(PictureBox pb)
        {
            if (lbl_Player.Text == "Player 1")
            {
                pb.Image = Resources.X;
                pb.Tag = 'X';
                return;
            }
                pb.Image = Resources.O;
                pb.Tag = 'O';
        }

        private Boolean CheckIfBeenClicked(PictureBox pb) {
            char Charchecked = Convert.ToChar(pb.Tag);
            if (Charchecked == 'X' || Charchecked == 'O')
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void SetNextPlayerLabel()
        {
            if (lbl_Player.Text == "Player 1")
                lbl_Player.Text = "Player 2";
            else
                lbl_Player.Text = "Player 1";
        }

        static bool IsThereAWinner = false;


        private char WhoWon()
        {
            if (Convert.ToChar(pb_TopLeft.Tag) == Convert.ToChar(pb_TopMid.Tag) 
                && Convert.ToChar(pb_TopMid.Tag) == Convert.ToChar(pb_TopRight.Tag))
            {
                pb_TopLeft.BackColor = Color.Green;
                pb_TopMid.BackColor = Color.Green;
                pb_TopRight.BackColor = Color.Green;
                IsThereAWinner = true;
                return Convert.ToChar(pb_TopLeft.Tag);
            }

            if (Convert.ToChar(pb_MidLeft.Tag) == Convert.ToChar(pb_MidMid.Tag) 
                && Convert.ToChar(pb_MidMid.Tag) == Convert.ToChar(pb_MidRight.Tag))
            {
                pb_MidLeft.BackColor = Color.Green;
                pb_MidMid.BackColor = Color.Green;
                pb_MidRight.BackColor = Color.Green;
                IsThereAWinner = true;

                return Convert.ToChar(pb_MidLeft.Tag);

            }

            if (Convert.ToChar(pb_BottomLeft.Tag) == Convert.ToChar(pb_BottomMid.Tag)&& 
                Convert.ToChar(pb_BottomMid.Tag) == Convert.ToChar(pb_BottomRight.Tag))
            {
                pb_BottomLeft.BackColor = Color.Green;
                pb_BottomMid.BackColor = Color.Green;
                pb_BottomRight.BackColor = Color.Green;
                IsThereAWinner = true;
                return Convert.ToChar(pb_BottomLeft.Tag);

            }

            if (Convert.ToChar(pb_TopLeft.Tag) == Convert.ToChar(pb_MidLeft.Tag)&&
                Convert.ToChar(pb_MidLeft.Tag)== Convert.ToChar(pb_BottomLeft.Tag))
            {
                pb_TopLeft.BackColor = Color.Green;
                pb_MidLeft.BackColor = Color.Green;
                pb_BottomLeft.BackColor = Color.Green;
                IsThereAWinner = true;
                return Convert.ToChar(pb_TopLeft.Tag);


            }

            if (Convert.ToChar(pb_TopMid.Tag) == Convert.ToChar(pb_MidMid.Tag) &&
                Convert.ToChar(pb_MidMid.Tag) == Convert.ToChar(pb_BottomMid.Tag))
            {
                pb_TopMid.BackColor = Color.Green;
                pb_MidMid.BackColor = Color.Green;
                pb_BottomMid.BackColor = Color.Green;
                IsThereAWinner = true;
                return Convert.ToChar(pb_TopMid.Tag);


            }

            if (Convert.ToChar(pb_TopRight.Tag) == Convert.ToChar(pb_MidRight.Tag) 
                && Convert.ToChar(pb_MidRight.Tag) == Convert.ToChar(pb_BottomRight.Tag))
            {
                pb_TopRight.BackColor = Color.Green;
                pb_MidRight.BackColor = Color.Green;
                pb_BottomRight.BackColor = Color.Green;
                IsThereAWinner = true;

                return Convert.ToChar(pb_TopRight.Tag);


            }


            if (Convert.ToChar(pb_TopLeft.Tag) == Convert.ToChar(pb_MidMid.Tag) &&
                Convert.ToChar(pb_MidMid.Tag) == Convert.ToChar(pb_BottomRight.Tag))
            {
                pb_TopLeft.BackColor = Color.Green;
                pb_MidMid.BackColor = Color.Green;
                pb_BottomRight.BackColor = Color.Green;
                IsThereAWinner = true;

                return Convert.ToChar(pb_TopLeft.Tag);


            }

            if (Convert.ToChar(pb_TopRight.Tag) == Convert.ToChar(pb_MidMid.Tag) 
                && Convert.ToChar(pb_MidMid.Tag) == Convert.ToChar(pb_BottomLeft.Tag))
            {
                pb_TopRight.BackColor = Color.Green;
                pb_MidMid.BackColor = Color.Green;
                pb_BottomLeft.BackColor = Color.Green;
                IsThereAWinner = true;

                return Convert.ToChar(pb_TopRight.Tag);
            }

            return 'D';
        }



        private void RestartGame()
        {
            IsThereAWinner = false;
            clicksCount = 0;
            pb_TopLeft.Image = Resources.question_mark_96;
            pb_TopMid.Image = Resources.question_mark_96;
            pb_TopRight.Image = Resources.question_mark_96;
            pb_MidLeft.Image = Resources.question_mark_96;
            pb_MidMid.Image = Resources.question_mark_96;
            pb_MidRight.Image = Resources.question_mark_96;
            pb_BottomLeft.Image = Resources.question_mark_96;
            pb_BottomMid.Image = Resources.question_mark_96;
            pb_BottomRight.Image = Resources.question_mark_96;
            pb_TopLeft.Tag = 1;
            pb_TopMid.Tag = 2;
            pb_TopRight.Tag = 3;
            pb_MidLeft.Tag = 4;
            pb_MidMid.Tag = 5;
            pb_MidRight.Tag = 6;
            pb_BottomLeft.Tag = 7;
            pb_BottomMid.Tag = 8;
            pb_BottomRight.Tag = 9;
            pb_TopLeft.BackColor = Color.Black;
            pb_TopMid.BackColor = Color.Black;
            pb_TopRight.BackColor = Color.Black;
            pb_MidLeft.BackColor = Color.Black;
            pb_MidMid.BackColor = Color.Black;
            pb_MidRight.BackColor = Color.Black;
            pb_BottomLeft.BackColor = Color.Black;
            pb_BottomMid.BackColor = Color.Black;
            pb_BottomRight.BackColor = Color.Black;

            lbl_Player.Text = "Player 1";
            lblWinner.Text = "In Progress";


        }
        private void GameOver()
        {
            char winner = WhoWon();
            if (IsThereAWinner == true)
            {
                lbl_Player.Text = "Game Over";

                if (winner == 'X')
                    lblWinner.Text = "Player 1";
                else if (winner == 'O')
                    lblWinner.Text = "Player 2";
                else
                    lblWinner.Text = "Draw";

                MessageBox.Show("Game Over","Game Over",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       

        }

        static byte clicksCount = 0;
        private void game_Click(object sender, EventArgs e)
        {
            clicksCount++;
            PictureBox pb = sender as PictureBox;

            if (CheckIfBeenClicked(pb))
            {
                clicksCount--;
                return;

            }
            if (clicksCount == 9)
            {
                IsThereAWinner = true;
            }
            setXOImageAndTag(pb);
            SetNextPlayerLabel();
            GameOver();


        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
