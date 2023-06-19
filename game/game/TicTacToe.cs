using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TicTacToe.Player;

namespace TicTacToe
{
    class TicTacToe
    {
		//Khoi tao
        public TicTacToe(){
            play();
        }
        
        //Luot choi
        public void play() {
            int moveCounter = 0;
            Board gameBoard = new Board();
            Player playerX = new Player('X');
           // Player playerO = new Player('O');
            Robot playerO=new Robot('O');
            Player currentPlayer = playerX;
            Player CurrentRobot = playerO;
            
            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    gameBoard.putMark(currentPlayer, playerX.takeTurn());
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.WriteLine("Player: {0} win!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if(CurrentRobot.checkWin(gameBoard))
                    {
                        Console.WriteLine("Robt: {0} win!", CurrentRobot.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }    
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                  
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
      
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }

    }

}

