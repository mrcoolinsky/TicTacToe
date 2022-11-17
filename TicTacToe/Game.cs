using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TicTacToe.Helpers;

namespace TicTacToe
{
    
    public class Game 
    {
        CurrentPlayer currentPlayer { get; set; }
        public string[] board = new string[9];
        public int coutner { get; set; }
        public string playerName { get; set; }


        public void NewGame(CurrentPlayer currentPlayer, int coutner)
        {
            this.currentPlayer = currentPlayer;
            this.coutner = coutner;
            ClearBoard();
        }

        public void Mark(object sender)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                playerName = "X";
                currentPlayer = CurrentPlayer.Circle;

            }
            else
            {
                senderButton.Text = "O";
                playerName = "O";
                currentPlayer = CurrentPlayer.Cross;
            }

            senderButton.Enabled = false;
            GameBoard(senderButton.Name, senderButton.Text);
            coutner++;

            if (coutner>4)
            {
               if (coutner > 8 && !CheckWinner())
               {
                    MessageBox.Show("Remis!");
               }
                CheckWinner();
            }

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
        public bool CheckWinner()
        {
            if (board[0]!= null && board[0] == board[1] && board[1] == board[2])
            {
                return true;
            }
            if (board[3] != null && board[3] == board[4] && board[4] == board[5])
            {     
                return true;
            }
            if (board[6] != null && board[6] == board[7] && board[7] == board[8])
            {
                return true;
            }

            if (board[0] != null && board[0] == board[3] && board[3] == board[6])
            {
                return true;
            }
            if (board[1] != null && board[1] == board[4] && board[4] == board[7])
            {
                return true;
            }
            if (board[2] != null && board[2] == board[5] && board[5] == board[8])
            {
                return true;
            }

            if (board[0] != null && board[0] == board[4] && board[4] == board[8])
            {
                return true;
            }
            if (board[2] != null && board[2] == board[4] && board[4] == board[6])
            {
                return true;
            }
            return false;
        }
        private void ClearBoard()
        {
            for (int i = 0; i< board.Length; i++)
            {
                board[i] = null;
            }
        }
        

        
       
        
    }

   
    
}
