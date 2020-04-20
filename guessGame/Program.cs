using System;

namespace guessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu selection phase
            Console.WriteLine("*====GUESS GAME LEVELS====*");
            Console.WriteLine("1 - EASY LEVEL\n" +
                            "2 - MEDIUM LEVEL\n"+
                            "3 - HARD LEVEL\n");
            Console.Write("Enter Level here:");
            int level = int.Parse(Console.ReadLine());
            //Checks when a user makes an INVALID ENTRY
            if(level <=3)
            {

                switch(level){
                    case 1:
                        Console.WriteLine("\nEASY==You are ALLOWED 6 guesses in this level==");
                        //Iterates throug 1 - 6 for easy level
                        for (int life=6;life>=1;life--)
                        {
                            Console.WriteLine("Remaining life: " + life + "\n");
                            Console.Write("Enter Guess:");
                            int guess = int.Parse(Console.ReadLine());
                            if(guess <= 10)
                            {
                                Console.WriteLine("***You got iT right***");
                                if(guess > 1)
                                {
                                    break;
                                }                 
                            }
                            else
                                {
                                 Console.WriteLine("---That was wrong---");
                                }
                
                            if(life == 1)
                            {
                                Console.WriteLine("\n---You have EXHAUSTED your guesses---GAME OVER!!!");
                                break;
                            }
                        }

                    break;

                case 2:
                        Console.WriteLine("\nMEDIUM==You are ALLOWED 4 guesses in this level==");
                        //Iterates throug 1 - 4 for medium level
                        for (int life=4;life>=1;life--)
                        {
                            Console.WriteLine("Remaining life: " + life + "\n");
                            Console.Write("Enter Guess:");
                            int guess = int.Parse(Console.ReadLine());

                            if(guess <= 20)
                            {
                                Console.WriteLine("***You got iT right***");
                                if(guess > 1)
                                {
                                    break;
                                }                 
                            }
                            else
                            {
                                Console.WriteLine("---That was wrong---");
                            }
                
                            if(life == 1)
                            {
                                Console.WriteLine("\n---You have EXHAUSTED your guesses---GAME OVER!!!");
                                break;
                            }
                        }
                    break;

                case 3:
                        Console.WriteLine("\nHARD==You are ALLOWED 3 guesses in this level==");
                        //Iterates throug 1 - 3 for hard level
                        for (int life=3;life>=1;life--)
                        {
                            Console.WriteLine("Remaining life: " + life + "\n");
                            Console.Write("Enter Guess:");
                            int guess = int.Parse(Console.ReadLine());

                            if(guess <= 50)
                            {
                                Console.WriteLine("***You got iT right***");
                                if(guess > 1)
                                {
                                    break;
                                }                 
                            }
                            else
                            {
                                Console.WriteLine("---That was wrong---");
                            }
                            if(life == 1)
                            {
                                Console.WriteLine("\n---You have EXHAUSTED your guesses---GAME OVER!!!");
                                break;
                            }
                        }
                    break;
                }
            }
            else
                {
                    Console.WriteLine("***Please, Choose a VALID Number(=Try Again=). Thank You***");
                }
        }
    }
}
