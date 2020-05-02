using System;
using System.Collections.Generic;

namespace ships_game
{
    public class Coordination
    {
        private int x;
        private int y;
        public static List<Coordination> corArray = new List<Coordination>();

        public Coordination(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int corX
        {
            get { return x; }
            set { x = value; }
        }
        public int corY
        {
            get { return y; }
            set { y = value; }
        }
    }
    public class Ships
    {
        public static string[] ships = { "BattleShip", "Carrier", "Cruiser", "Ship" };
    }
    public class Validation
    {
        public void getUserInput()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("\nType coordination number X");
                dynamic corX = Console.ReadLine();
                Console.WriteLine("\nType coordination number Y");
                dynamic corY = Console.ReadLine();
                try
                {
                    int validatedCorX = Int32.Parse(corX);
                    int validatedCorY = Int32.Parse(corY);
                    Coordination.corArray.Add(new Coordination(validatedCorX, validatedCorY));
                    isValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse, not a number");
                    Console.WriteLine("You have to insert coordinations again");
                    isValid = false;
                    Console.Beep();
                }
            }
        }
    }
    public class InitSetup
    {
        // public Validation validation;
        // UserCoordination userCoodination = new UserCoordination();
        public void addShipsCoordination()
        {
            Validation validation = new Validation();
            for (int i = 0; i < Ships.ships.Length; i++)
            {
                validation.getUserInput();
                // userCoodination.setCoordinations(validatedCorX, validatedCorY);
                // UserCoordination.CorArray.Add({ validatedCorX, validatedCorY});
            }
        }
        public void generateInfoForUser()
        {
            Console.WriteLine("starting");
            for (int i = 1; i <= 11; i++)
            {
                Console.WriteLine(' ');
                for (int j = 1; j <= 11; j++)
                {
                    if (j == 1)
                    {
                        Console.Write(" " + (i - 1) + " ");
                    }
                    else if (i == 1)
                    {
                        Console.Write((j - 1) + 10 + " ");
                    }
                    else
                    {
                        Console.Write(" x ");
                    }
                }
            }
        }
    }
    public class Game
    {
        public void newGame()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Game game1 = new Game();
            // game1.newGame();
            InitSetup setup = new InitSetup();
            setup.generateInfoForUser();
            setup.addShipsCoordination();
            foreach(var cor in Coordination.corArray)
            {
                Console.WriteLine(cor.corX);
                Console.WriteLine(cor.corY);
            }
            Console.ReadKey();
        }
    }
}
