using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinesweeperLib;

namespace MinesweeperUI
{
    public partial class MinesweeperForm : Form
    {
        Minesweeper _minesweeper = new Minesweeper();
        private Button button;


        public MinesweeperForm()
        {
            InitializeComponent();
        }

        private void MinesweeperForm_Load(object sender, EventArgs e)
        {

           
        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int row = gridLayoutPanel.GetCellPosition(button).Row;
            int column = gridLayoutPanel.GetCellPosition(button).Column;
            MouseLeftClick(e, button, row, column);
            MouseRightClick(e, button, row, column);

            if (_minesweeper.CheckGameWin())
            {
                win_lbl.Visible = true;

            }

        }



        private void MouseLeftClick(MouseEventArgs e, Button button, int row, int column)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                _minesweeper.ExposeCell(column, row);
                CheckAdjacentAndUnsealed(button, row, column);
                CheckMine(button, row, column);
                CheckDisplayOnCellEmpty(button, row, column);
                CheckDisplayOnCellSealed(row, column);
            }
        }

        private void MouseRightClick(MouseEventArgs e, Button button, int row, int column)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (_minesweeper.DisplayOnCell(column, row).ToString() == "S")
                {
                    _minesweeper.UnsealACell(column, row);
                    button.Text = " ";
                }
                else
                {
                    _minesweeper.SealACell(column, row);
                    button.Text = _minesweeper.DisplayOnCell(column, row).ToString();
                }
            }
        }

        private void CheckDisplayOnCellSealed(int row, int column)
        {
            if (_minesweeper.DisplayOnCell(column, row).ToString() == "S")
            {
                MessageBox.Show("unseal it to expose");
            }
        }

        private void CheckDisplayOnCellEmpty(Button button, int row, int column)
        {
            if (_minesweeper.DisplayOnCell(column, row).ToString() == " ")
            {
                button.Enabled = false;
                _minesweeper.ExposeNeighboringCells(column, row);

                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                    {
                        if (_minesweeper.DisplayOnCell(i, j) != 'M' && _minesweeper.DisplayOnCell(i, j) != 'S' && _minesweeper.DisplayOnCell(i, j) != 'U')
                        {
                            gridLayoutPanel.GetControlFromPosition(i, j).Text = _minesweeper.DisplayOnCell(i, j).ToString();
                            gridLayoutPanel.GetControlFromPosition(i, j).Enabled = false;
                        }
                    }
            }
        }

        private void CheckMine(Button button, int row, int column)
        {
            if (_minesweeper.DisplayOnCell(column, row).ToString() == "M")
            {
                button.Enabled = false;
                button.Text = _minesweeper.DisplayOnCell(column, row).ToString();
                _minesweeper.IsGameOver();
                Gameover_lbl.Visible = true;
                btnRestart.Visible = true;
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                    {
                        _minesweeper.ExposeCell(i, j);
                        gridLayoutPanel.GetControlFromPosition(i, j).Text = _minesweeper.DisplayOnCell(i, j).ToString();
                        if (gridLayoutPanel.GetControlFromPosition(i, j).Text == "M" || gridLayoutPanel.GetControlFromPosition(i, j).Text == "S")
                        {
                            gridLayoutPanel.GetControlFromPosition(i, j).Text = "M";
                            gridLayoutPanel.GetControlFromPosition(i, j).BackColor = Color.Red;
                        }
                        gridLayoutPanel.GetControlFromPosition(i, j).Enabled = false;
                    }
            }
        }

        private void CheckAdjacentAndUnsealed(Button button, int row, int column)
        {
            if (_minesweeper.GetAdjacentCellCount(column, row) != 0 && _minesweeper.DisplayOnCell(column, row).ToString() != "S")
            {
                button.Enabled = false;
                button.Text = _minesweeper.DisplayOnCell(column, row).ToString();
            }
        }

        private void bntPlay_Click(object sender, EventArgs e)
        {
            welcomeLbl.Visible = false;
            bntPlay.Visible = false;
            welcomePanel.Visible = false;

            IntializeTheBoard();
        }

        private void IntializeTheBoard()
        {
            _minesweeper.Start();
            gridLayoutPanel.Visible = true;
            _minesweeper.PlaceMines();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    button = new Button();
                    button.MouseDown += new System.Windows.Forms.MouseEventHandler(button_Click);
                    button.Visible = true;
                    button.Anchor = AnchorStyles.Left;
                    gridLayoutPanel.Controls.Add(button, i, j);
                }
            }
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            Gameover_lbl.Visible = false;
            gridLayoutPanel.Controls.Clear();
            Minesweeper _minesweeper = new Minesweeper();
            IntializeTheBoard();  
        }
    }
}

