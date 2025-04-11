namespace MyFirstWinFormsProject
{
    partial class HisTicTac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.lbl_Player = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pb_BottomRight = new System.Windows.Forms.PictureBox();
            this.pb_BottomMid = new System.Windows.Forms.PictureBox();
            this.pb_MidRight = new System.Windows.Forms.PictureBox();
            this.pb_MidMid = new System.Windows.Forms.PictureBox();
            this.pb_TopRight = new System.Windows.Forms.PictureBox();
            this.pb_TopMid = new System.Windows.Forms.PictureBox();
            this.pb_BottomLeft = new System.Windows.Forms.PictureBox();
            this.pb_MidLeft = new System.Windows.Forms.PictureBox();
            this.pb_TopLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(661, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(167, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 67);
            this.label3.TabIndex = 11;
            this.label3.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(136, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 67);
            this.label2.TabIndex = 12;
            this.label2.Text = "Winner";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(52, 538);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(378, 85);
            this.btnRestartGame.TabIndex = 13;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player.ForeColor = System.Drawing.Color.White;
            this.lbl_Player.Location = new System.Drawing.Point(136, 255);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(251, 67);
            this.lbl_Player.TabIndex = 14;
            this.lbl_Player.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(90, 428);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(340, 67);
            this.lblWinner.TabIndex = 15;
            this.lblWinner.Text = "In Progress";
            // 
            // pb_BottomRight
            // 
            this.pb_BottomRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_BottomRight.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_BottomRight.Location = new System.Drawing.Point(1123, 604);
            this.pb_BottomRight.Name = "pb_BottomRight";
            this.pb_BottomRight.Size = new System.Drawing.Size(100, 107);
            this.pb_BottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_BottomRight.TabIndex = 9;
            this.pb_BottomRight.TabStop = false;
            this.pb_BottomRight.Tag = "9";
            // 
            // pb_BottomMid
            // 
            this.pb_BottomMid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_BottomMid.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_BottomMid.Location = new System.Drawing.Point(874, 604);
            this.pb_BottomMid.Name = "pb_BottomMid";
            this.pb_BottomMid.Size = new System.Drawing.Size(100, 107);
            this.pb_BottomMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_BottomMid.TabIndex = 8;
            this.pb_BottomMid.TabStop = false;
            this.pb_BottomMid.Tag = "8";
            // 
            // pb_MidRight
            // 
            this.pb_MidRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MidRight.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_MidRight.Location = new System.Drawing.Point(1123, 370);
            this.pb_MidRight.Name = "pb_MidRight";
            this.pb_MidRight.Size = new System.Drawing.Size(100, 107);
            this.pb_MidRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_MidRight.TabIndex = 7;
            this.pb_MidRight.TabStop = false;
            this.pb_MidRight.Tag = "6";
            // 
            // pb_MidMid
            // 
            this.pb_MidMid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MidMid.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_MidMid.Location = new System.Drawing.Point(874, 370);
            this.pb_MidMid.Name = "pb_MidMid";
            this.pb_MidMid.Size = new System.Drawing.Size(100, 107);
            this.pb_MidMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_MidMid.TabIndex = 6;
            this.pb_MidMid.TabStop = false;
            this.pb_MidMid.Tag = "5";
            // 
            // pb_TopRight
            // 
            this.pb_TopRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_TopRight.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_TopRight.Location = new System.Drawing.Point(1123, 156);
            this.pb_TopRight.Name = "pb_TopRight";
            this.pb_TopRight.Size = new System.Drawing.Size(100, 107);
            this.pb_TopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_TopRight.TabIndex = 5;
            this.pb_TopRight.TabStop = false;
            this.pb_TopRight.Tag = "3";
            // 
            // pb_TopMid
            // 
            this.pb_TopMid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_TopMid.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_TopMid.Location = new System.Drawing.Point(874, 156);
            this.pb_TopMid.Name = "pb_TopMid";
            this.pb_TopMid.Size = new System.Drawing.Size(100, 107);
            this.pb_TopMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_TopMid.TabIndex = 4;
            this.pb_TopMid.TabStop = false;
            this.pb_TopMid.Tag = "2";
            // 
            // pb_BottomLeft
            // 
            this.pb_BottomLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_BottomLeft.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_BottomLeft.Location = new System.Drawing.Point(619, 604);
            this.pb_BottomLeft.Name = "pb_BottomLeft";
            this.pb_BottomLeft.Size = new System.Drawing.Size(100, 107);
            this.pb_BottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_BottomLeft.TabIndex = 3;
            this.pb_BottomLeft.TabStop = false;
            this.pb_BottomLeft.Tag = "7";
            // 
            // pb_MidLeft
            // 
            this.pb_MidLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_MidLeft.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_MidLeft.Location = new System.Drawing.Point(619, 370);
            this.pb_MidLeft.Name = "pb_MidLeft";
            this.pb_MidLeft.Size = new System.Drawing.Size(100, 107);
            this.pb_MidLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_MidLeft.TabIndex = 2;
            this.pb_MidLeft.TabStop = false;
            this.pb_MidLeft.Tag = "4";
            // 
            // pb_TopLeft
            // 
            this.pb_TopLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_TopLeft.Image = global::MyFirstWinFormsProject.Properties.Resources.question_mark_96;
            this.pb_TopLeft.Location = new System.Drawing.Point(619, 156);
            this.pb_TopLeft.Name = "pb_TopLeft";
            this.pb_TopLeft.Size = new System.Drawing.Size(106, 107);
            this.pb_TopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_TopLeft.TabIndex = 1;
            this.pb_TopLeft.TabStop = false;
            this.pb_TopLeft.Tag = "1";
            // 
            // HisTicTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 773);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lbl_Player);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_BottomRight);
            this.Controls.Add(this.pb_BottomMid);
            this.Controls.Add(this.pb_MidRight);
            this.Controls.Add(this.pb_MidMid);
            this.Controls.Add(this.pb_TopRight);
            this.Controls.Add(this.pb_TopMid);
            this.Controls.Add(this.pb_BottomLeft);
            this.Controls.Add(this.pb_MidLeft);
            this.Controls.Add(this.pb_TopLeft);
            this.Controls.Add(this.label1);
            this.Name = "HisTicTac";
            this.Text = "Tic-Tac-Toe Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MidLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_TopLeft;
        private System.Windows.Forms.PictureBox pb_MidLeft;
        private System.Windows.Forms.PictureBox pb_BottomLeft;
        private System.Windows.Forms.PictureBox pb_TopMid;
        private System.Windows.Forms.PictureBox pb_TopRight;
        private System.Windows.Forms.PictureBox pb_MidMid;
        private System.Windows.Forms.PictureBox pb_MidRight;
        private System.Windows.Forms.PictureBox pb_BottomMid;
        private System.Windows.Forms.PictureBox pb_BottomRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.Label lbl_Player;
        private System.Windows.Forms.Label lblWinner;

    }
}