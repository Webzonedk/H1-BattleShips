using System;
using System.Collections.Generic;
using System.Threading;

namespace BattleShips
{
    class Program
    {
           static GameController gameController = new GameController();
        static void Main(string[] args)
        {
           


            //Creating gameareas
            GameArea playerArea = gameController.CreateGameArea(10, 10, 0);
            GameArea computerArea = gameController.CreateGameArea(10, 10, 0);
            string[] rowLetters = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            List<Ship> ships = new List<Ship>();
            ships.Add(new Ship("Carrier", 5, true));
            ships.Add(new Ship("Battleship", 4, true));
            ships.Add(new Ship("Cruiser", 3, true));
            ships.Add(new Ship("Submarine", 3, true));
            ships.Add(new Ship("Destroyer", 2, true));

            List<Ship> playerShips = new List<Ship>();
            playerShips.Add(new Ship("Carrier", 5, true));
            playerShips.Add(new Ship("Battleship", 4, true));
            playerShips.Add(new Ship("Cruiser", 3, true));
            playerShips.Add(new Ship("Submarine", 3, true));
            playerShips.Add(new Ship("Destroyer", 2, true));

            List<Ship> computerShips = new List<Ship>();
            computerShips.Add(new Ship("Carrier", 5, true));
            computerShips.Add(new Ship("Battleship", 4, true));
            computerShips.Add(new Ship("Cruiser", 3, true));
            computerShips.Add(new Ship("Submarine", 3, true));
            computerShips.Add(new Ship("Destroyer", 2, true));



            Console.WriteLine();
            Console.WriteLine("   |==================================================================================|");
            Console.WriteLine("   |================================  Place your ships!  =============================|");
            Console.WriteLine("   |==================================================================================|");




            ShowBanner(); //Creating a bautifull banner from an ASCii file.
            
            //Sending the arguments to the methods by including those in the brackets. They can only be read this way
            gameController.FillGameArea(computerArea, playerArea);
            ShowGameArea(computerArea, playerArea, rowLetters);
            ShowChooseShip(playerShips);
            Ship choosenShip = gameController.ChoosePlayerShip(playerShips);
            ChooseDirection(choosenShip);
            //ShowPlaceYourShip();

            ShowPlaceXCordinate();
            gameController.PlaceX();
            ShowPlaceYCordinate();
            gameController.PlaceY();

            gameController.PlacePlayerShip(playerArea, choosenShip);
            

        }




        /// <summary>
        /// Creating a bautifull banner from an ASCii file.
        /// </summary>
        public static void ShowBanner()
        {
            string[] banner = System.IO.File.ReadAllLines("../../../Graphic/ASCii");
            foreach (string item in banner)
            {
                Console.WriteLine(item);
            }
            Thread.Sleep(1);
            Console.Clear();
        }




        /// <summary>
        /// Shows the menu for choosing which ship to place
        /// </summary>
        /// <param name="playerShips"></param>
        public static void ShowChooseShip(List<Ship> playerShips)
        {
            for (int i = 0; i < playerShips.Count; i++)
            {
                Console.WriteLine($"Press {i}: to place your {playerShips[i].Name}");
            }
        }




        /// <summary>
        /// Shows the menu for choosing the direction of the ship
        /// </summary>
        public static void ChooseDirection(Ship playerShip)//refering to the choosen ship but can be called whatever you like
        {
            Console.WriteLine("Choose direction");
            Console.WriteLine($"Horisontal: Press 1: Vertical: Press 2");
            Ship theShip = gameController.ChoosePlayershipDirection(playerShip);

            if (theShip.Direction==true)
            {
            Console.WriteLine($"You choose Horisontal");
            }
            else
            {
                Console.WriteLine($"You choose vertical");
            }
            //return choosenShip;
        }




        public static void ShowPlaceYourShip()
        {
            Console.WriteLine("Choose the cordinate to place you ship");
            Console.WriteLine("You can only place it if it stays withing the game area");
        }




        public static void ShowPlaceXCordinate()
        {
            Console.WriteLine("Choose the X cordinate");
        }




         public static void ShowPlaceYCordinate()
        {
            Console.WriteLine("Choose the Y cordinate");
        }




        /// <summary>
        /// Displaying the playing fields.
        /// </summary>
        /// <param name="computerArea"></param>
        /// <param name="playerArea"></param>
        /// <param name="rowLetters"></param>
        public static void ShowGameArea(GameArea computerArea, GameArea playerArea, string[] rowLetters)
        {
            Console.WriteLine("   |=========================================|========================================|");
            Console.WriteLine("   |            Computer game area           |            Player game area            |");
            Console.WriteLine("   |=========================================|========================================|");
            Console.WriteLine("   |        A  B  C  D  E  F  G  H  I  J     |        A  B  C  D  E  F  G  H  I  J    |");
            Console.WriteLine();
            for (int i = 0; i < computerArea.GameAreaArray.GetLength(0); i++)
            {

                Console.Write("   |   ");
                Console.Write($"{rowLetters[i],3}  ");
                for (int j = 0; j < computerArea.GameAreaArray.GetLength(1); j++)
                {
                    // Console.Write("X  ");
                    Console.Write($"{computerArea.GameAreaArray[i, j]}  ");
                }
                Console.Write("   |   ");
                Console.Write($"{rowLetters[i],3}  ");
                for (int k = 0; k < playerArea.GameAreaArray.GetLength(1); k++)
                {
                    // Console.Write("X  ");
                    Console.Write($"{computerArea.GameAreaArray[i, k]}  ");
                }
                Console.Write("  |\n\n");
            }
            Console.WriteLine("   |=========================================|========================================|");






        


        }
    }
}
