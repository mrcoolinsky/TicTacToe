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
        string[] board = new string[9];


        public void Mark(object sender)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
                senderButton.Enabled = false;
                GameBoard(senderButton.Name, senderButton.Text);
                
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
                senderButton.Enabled = false;
                GameBoard(senderButton.Name, senderButton.Text);
            }
            CheckWinner();

        }
        public  string ChangeMarkLabel()
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
        
        private void GameBoard(object sender, string mark)
        {
            switch(sender)
            {
                case "btn_0_0":
                    board[0] = mark;
                    break;
                case "btn_0_1":
                    board[1] = mark;
                    break;
                case "btn_0_2":
                    board[2] = mark;
                    break;
                case "btn_1_0":
                    board[3] = mark;
                    break;
                case "btn_1_1":
                    board[4] = mark;
                    break;
                case "btn_1_2":
                    board[5] = mark;
                    break;
                case "btn_2_0":
                    board[6] = mark;
                    break;
                case "btn_2_1":
                    board[7] = mark;
                    break;
                case "btn_2_2":
                    board[8] = mark;
                    break;
            }
        }
        public void CheckWinner()
        {
            if(board[0] == board[1] && board[1] == board[2])
            {
                MessageBox.Show("Unable to save file, try again.");
            }
            
        }
       
        
    }

   
    
}
