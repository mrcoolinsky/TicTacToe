using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicTacToe.Game;
using static TicTacToe.Helpers;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        
       
        public Form1()
        {
            InitializeComponent();
            game.NewGame(CurrentPlayer.Cross, 0);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            game.Mark(sender);
            lbl_currentPlayer.Text = game.ChangeMarkLabel();
            UICheckWinner();
            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            game.NewGame(CurrentPlayer.Cross, 0);
            NewInterface();


        }

        private void UICheckWinner()
        {
            bool gameWinner = game.CheckWinner();
            if (gameWinner == true)
            {
                MessageBox.Show("Gratulacje, wygrywa: " + game.playerName);
                LockAllButtons();

            }
        }
        private void NewInterface()
        {
            btn_0_0.Text = string.Empty;
            btn_0_0.Enabled = true;
            btn_0_1.Text = string.Empty;
            btn_0_1.Enabled = true;
            btn_0_2.Text = string.Empty;
            btn_0_2.Enabled = true;
            btn_1_0.Text = string.Empty;
            btn_1_0.Enabled = true;
            btn_1_1.Text = string.Empty;
            btn_1_1.Enabled = true;
            btn_1_2.Text = string.Empty;
            btn_1_2.Enabled = true;
            btn_2_0.Text = string.Empty;
            btn_2_0.Enabled = true;
            btn_2_1.Text = string.Empty;
            btn_2_1.Enabled = true;
            btn_2_2.Text = string.Empty;
            btn_2_2.Enabled = true;
            lbl_currentPlayer.Text = game.ChangeMarkLabel();
        }
        public void LockAllButtons()
        {
            btn_0_0.Enabled = false;
            btn_0_1.Enabled = false;
            btn_0_2.Enabled = false;
            btn_1_0.Enabled = false;
            btn_1_1.Enabled = false;
            btn_1_2.Enabled = false;
            btn_2_0.Enabled = false;
            btn_2_1.Enabled = false;
            btn_2_2.Enabled = false;
        }
    }
}
