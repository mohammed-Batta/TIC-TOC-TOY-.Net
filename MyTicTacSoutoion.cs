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
    public partial class HisTicTac : Form
    {
        public HisTicTac()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
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
        enum enPlayerTurn
        {
            Player1, Player2
        }

        enum enWinner
        {
            player1,
            Player2,
            Draw,
            InProgress
        }
        struct stGameStatus
        {
            public enWinner winner;
            public enPlayerTurn PlayerTurn;
            public byte PlayCount;
            public bool GameOver;
        }

         stGameStatus GameStatus ;


        public void EndGame()
        {
            lbl_Player.Text = "Game Over";
            switch (GameStatus.winner)
            {
                case enWinner.player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool checkValues(PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {
            if (pic1.Tag.ToString() != "?" && pic1.Tag.ToString() == pic2.Tag.ToString() && pic2.Tag.ToString() == pic3.Tag.ToString())
            {
                pic1.BackColor = Color.GreenYellow;
                pic2.BackColor = Color.GreenYellow;
                pic3.BackColor = Color.GreenYellow;
                GameStatus.GameOver = true;
                if (pic1.Tag.ToString() == "X")
                {
                    GameStatus.winner = enWinner.player1;
                    EndGame();
                    return true;
                }
                else if (pic1.Tag.ToString() == "O")
                {
                    GameStatus.winner = enWinner.Player2;
                    EndGame();
                    return true;
                }
               
            }
            GameStatus.GameOver = false;

            return false;
        }

        public void CheckWinner()
        {

            if (checkValues(pb_TopLeft, pb_TopMid, pb_TopRight))
                return;
            if (checkValues(pb_MidLeft, pb_MidMid, pb_MidRight))
                return;
            if (checkValues(pb_BottomLeft, pb_BottomMid, pb_BottomRight))
                return;
            if (checkValues(pb_TopLeft, pb_MidLeft, pb_BottomLeft))
                return;
            if (checkValues(pb_TopMid, pb_MidMid, pb_BottomMid))
                return;
            if (checkValues(pb_TopRight, pb_MidRight, pb_BottomRight))
                return;
            if (checkValues(pb_TopLeft, pb_MidMid, pb_BottomRight))
                return;
            if (checkValues(pb_TopRight, pb_MidMid, pb_BottomLeft))
                return;



        }

        public void ChangeImage(PictureBox pic)
        {
            PictureBox pb = pic;

            if (pb.Tag.ToString() == "?")
            {
                switch (GameStatus.PlayerTurn)
                {
                   case enPlayerTurn.Player1:
                        pb.Image = Resources.X;
                        pb.Tag = "X";
                        GameStatus.PlayerTurn = enPlayerTurn.Player2;
                        GameStatus.PlayCount++;
                        lbl_Player.Text = "Player 2";
                        CheckWinner();
                        break;

                    case enPlayerTurn.Player2:
                        pb.Image = Resources.O;
                        pb.Tag = "O";
                        GameStatus.PlayerTurn = enPlayerTurn.Player1;
                        GameStatus.PlayCount++;
                        lbl_Player.Text = "Player 1";
                        CheckWinner();
                        break;


                }


            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(GameStatus.PlayCount == 9)
            {
                GameStatus.winner = enWinner.Draw;
                EndGame();
            }
        }
        private void OnClick(object sender, EventArgs e)
        {

            ChangeImage((PictureBox)sender);

        }

        public void ResetPicBox(PictureBox pb) {
            pb.Image = Resources.question_mark_96;
            pb.Tag = "?";
            pb.BackColor = Color.Black;
        }

        public void RestartGame()
        {
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.winner = enWinner.InProgress;
            GameStatus.PlayerTurn = enPlayerTurn.Player1;
            lbl_Player.Text = "Player 1";
            lblWinner.Text = "In Progress";
            ResetPicBox(pb_TopLeft);
            ResetPicBox(pb_TopMid);
            ResetPicBox(pb_TopRight);
            ResetPicBox(pb_MidLeft);
            ResetPicBox(pb_MidMid);
            ResetPicBox(pb_MidRight);
            ResetPicBox(pb_BottomLeft);
            ResetPicBox(pb_BottomMid);
            ResetPicBox(pb_BottomRight);
           

        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
