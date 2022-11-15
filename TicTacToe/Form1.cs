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
            lbl_currentPlayer.Text = game.ChangeMarkLabel();
            


        }
        
    }
}
