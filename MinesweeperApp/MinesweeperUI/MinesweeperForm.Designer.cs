namespace MinesweeperUI
{
    partial class MinesweeperForm
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
            this.gridLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Minesweeper_lbl = new System.Windows.Forms.Label();
            this.Gameover_lbl = new System.Windows.Forms.Label();
            this.win_lbl = new System.Windows.Forms.Label();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.bntPlay = new System.Windows.Forms.Button();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.welcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLayoutPanel
            // 
            this.gridLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gridLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.gridLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridLayoutPanel.ColumnCount = 10;
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.Location = new System.Drawing.Point(88, 31);
            this.gridLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gridLayoutPanel.Name = "gridLayoutPanel";
            this.gridLayoutPanel.RowCount = 10;
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gridLayoutPanel.Size = new System.Drawing.Size(302, 311);
            this.gridLayoutPanel.TabIndex = 0;
            this.gridLayoutPanel.Visible = false;
            // 
            // Minesweeper_lbl
            // 
            this.Minesweeper_lbl.AutoSize = true;
            this.Minesweeper_lbl.ForeColor = System.Drawing.Color.Green;
            this.Minesweeper_lbl.Location = new System.Drawing.Point(190, 9);
            this.Minesweeper_lbl.Name = "Minesweeper_lbl";
            this.Minesweeper_lbl.Size = new System.Drawing.Size(70, 13);
            this.Minesweeper_lbl.TabIndex = 1;
            this.Minesweeper_lbl.Text = "Minesweeper";
            // 
            // Gameover_lbl
            // 
            this.Gameover_lbl.AutoSize = true;
            this.Gameover_lbl.ForeColor = System.Drawing.Color.Red;
            this.Gameover_lbl.Location = new System.Drawing.Point(411, 212);
            this.Gameover_lbl.Name = "Gameover_lbl";
            this.Gameover_lbl.Size = new System.Drawing.Size(113, 13);
            this.Gameover_lbl.TabIndex = 2;
            this.Gameover_lbl.Text = "Game Over.You loss :(";
            this.Gameover_lbl.Visible = false;
            // 
            // win_lbl
            // 
            this.win_lbl.AutoSize = true;
            this.win_lbl.ForeColor = System.Drawing.Color.Green;
            this.win_lbl.Location = new System.Drawing.Point(432, 144);
            this.win_lbl.Name = "win_lbl";
            this.win_lbl.Size = new System.Drawing.Size(57, 13);
            this.win_lbl.TabIndex = 3;
            this.win_lbl.Text = "You Win !!";
            this.win_lbl.Visible = false;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(19, 48);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(491, 37);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome to Minesweeper Game";
            // 
            // bntPlay
            // 
            this.bntPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntPlay.ForeColor = System.Drawing.Color.Crimson;
            this.bntPlay.Location = new System.Drawing.Point(204, 119);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(97, 58);
            this.bntPlay.TabIndex = 0;
            this.bntPlay.Text = "Play";
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.Controls.Add(this.bntPlay);
            this.welcomePanel.Controls.Add(this.welcomeLbl);
            this.welcomePanel.Location = new System.Drawing.Point(14, 9);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(521, 345);
            this.welcomePanel.TabIndex = 4;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Crimson;
            this.btnRestart.Location = new System.Drawing.Point(414, 61);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(110, 46);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 378);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.win_lbl);
            this.Controls.Add(this.Gameover_lbl);
            this.Controls.Add(this.Minesweeper_lbl);
            this.Controls.Add(this.gridLayoutPanel);
            this.Name = "MinesweeperForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MinesweeperForm_Load);
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridLayoutPanel;
        private System.Windows.Forms.Label Minesweeper_lbl;
        private System.Windows.Forms.Label Gameover_lbl;
        private System.Windows.Forms.Label win_lbl;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Button btnRestart;
    }
}

