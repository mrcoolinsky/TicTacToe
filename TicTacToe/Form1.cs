using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicTacToe.Game;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(1, lbl_currentPlayer.Text);
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(1, lbl_currentPlayer.Text);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(2, lbl_currentPlayer.Text);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(3, lbl_currentPlayer.Text);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(4, lbl_currentPlayer.Text);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(5, lbl_currentPlayer.Text);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(6, lbl_currentPlayer.Text);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(7, lbl_currentPlayer.Text);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(8, lbl_currentPlayer.Text);
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.changeMarkLabel();
            game.gameBoard(9, lbl_currentPlayer.Text);
        }
    }
}
