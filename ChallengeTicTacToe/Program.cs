

namespace ChallengeTicTacToe
{
    class Program
    {
        //the playfield
        static char[,] playFiled =
        {
            {'1', '2', '3'}, //Row 0
            {'4', '5', '6'}, //Row 1
            {'7', '8', '9'}  //Row 2
        };
       
        static int turn = 0;

        static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;   

            //Run code as long as the program runs
            do
            {  
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if(player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                setField();

                #region
                //check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char c in playerChars)
                {
                    if (((playFiled[0,0] == c) && (playFiled[0,1] == c) && (playFiled[0,2] == c)
                        || (playFiled[1, 0] == c) && (playFiled[1, 1] == c) && (playFiled[1, 2] == c)
                        || (playFiled[2, 0] == c) && (playFiled[2, 1] == c) && (playFiled[2, 2] == c)
                        || (playFiled[0, 0] == c) && (playFiled[1, 0] == c) && (playFiled[2, 0] == c)
                        || (playFiled[0, 1] == c) && (playFiled[1, 1] == c) && (playFiled[2, 1] == c)
                        || (playFiled[0, 2] == c) && (playFiled[1, 2] == c) && (playFiled[2, 2] == c)
                        || (playFiled[0, 0] == c) && (playFiled[1, 1] == c) && (playFiled[2, 2] == c)
                        || (playFiled[0, 2] == c) && (playFiled[1, 1] == c) && (playFiled[2, 0] == c)))
                    {
                        if(c == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }

                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        //TODO reset field 
                        ResetField();

                        break;
                    }
                    else if(turn == 10)
                    {
                        Console.WriteLine("\n DRAW ");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                #endregion

                #region
                //test is field is already taken 
                do
                {
                    Console.Write("\nPlayer {0}: Choose your field ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    { Console.WriteLine("Please enter a number"); }
                    

                    if((input == 1) && (playFiled[0,0] == '1')){
                        inputCorrect = true;
                    }
                    else if((input == 2) && (playFiled[0,1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playFiled[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playFiled[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playFiled[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playFiled[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playFiled[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playFiled[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playFiled[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input ! Please use another field");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
             #endregion   

            }while (true);            
        }

        public static void ResetField()
        {
            //Create new array playFiledInitial for reset the game
            char[,] playFiledInitial =
             {
                {'1', '2', '3'}, //Row 0
                {'4', '5', '6'}, //Row 1
                {'7', '8', '9'}  //Row 2
            };

            playFiled = playFiledInitial;
            setField();
            turn = 0;
        }

        public static void setField()
        {
            //Todo replace numbers with variables
            Console.Clear();
            Console.WriteLine("        |        |       ");
            Console.WriteLine("   {0}    |   {1}    |   {2}     ", playFiled[0,0], playFiled[0, 1], playFiled[0, 2]);
            Console.WriteLine("________|________|_______");
            Console.WriteLine("        |        |       ");
            Console.WriteLine("   {0}    |   {1}    |   {2}     ", playFiled[1, 0], playFiled[1, 1], playFiled[1, 2]);
            Console.WriteLine("________|________|_______");
            Console.WriteLine("        |        |       ");
            Console.WriteLine("   {0}    |   {1}    |   {2}     ", playFiled[2, 0], playFiled[2, 1], playFiled[2, 2]);
            Console.WriteLine("        |        |       ");
            turn++;
        }

        public static void EnterXorO(char playerSign, int input) 
        {
            switch (input)
            {
                case 1:
                    playFiled[0, 0] = playerSign;
                    break;
                case 2:
                    playFiled[0, 1] = playerSign;
                    break;
                case 3:
                    playFiled[0, 2] = playerSign;
                    break;
                case 4:
                    playFiled[1, 0] = playerSign;
                    break;
                case 5:
                    playFiled[1, 1] = playerSign;
                    break;
                case 6:
                    playFiled[1, 2] = playerSign;
                    break;
                case 7:
                    playFiled[2, 0] = playerSign;
                    break;
                case 8:
                    playFiled[2, 1] = playerSign;
                    break;
                case 9:
                    playFiled[2, 2] = playerSign;
                    break;
            }
        }
    }
}

