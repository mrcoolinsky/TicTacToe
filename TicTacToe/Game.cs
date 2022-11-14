using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicTacToe.Helpers;

namespace TicTacToe
{
    
    public class Game 
    {
        CurrentPlayer currentPlayer = CurrentPlayer.Cross;
        
        private int[,] board = new int[3, 3];

        public void Mark(object sender)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
            }
        }
    }

   
    
}
