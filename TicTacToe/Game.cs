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
        
        
        
        public void Mark(object sender)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
                senderButton.Enabled = false;
                
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
                senderButton.Enabled = false;
            }
            
        }
        public  string changeMarkLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
        
        public int gameBoard(int key, string mark)
        {
            string[,] board = new string[3, 3];
            switch(key)
            {
                case 1:
                    board[0, 0] = mark;
                    break;
                case 2:
                    board[0, 1] = mark;
                    break;
                case 3:
                    board[0, 2] = mark;
                    break;
                case 4:
                    board[1, 0] = mark;
                    break;
                case 5:
                    board[1, 1] = mark;
                    break;
                case 6:
                    board[1, 2] = mark;
                    break;
                case 7:
                    board[2, 0] = mark;
                    break;
                case 8:
                    board[2, 1] = mark;
                    break;
                case 9:
                    board[2, 2] = mark;
                    break;
                default:

                    break;

            }


            return key;
        }
    }

   
    
}
