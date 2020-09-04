using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    class GameController
    {
        #region Fields
        //private GameArea userArea, computerArea;
        //private byte height;
        //private byte width;
        // private bool run;
        #endregion

        #region Properties

        //public int[,] UserAreaArray
        //{
        //    get { return userArea.GameAreaArray; }
        //}
        //public int[,] ComputerAreaArray
        //{
        //    get { return computerArea.GameAreaArray; }
        //}

        #endregion

        #region constructor     
        public GameController()
        {

        }
        #endregion


        #region Methods
        public GameArea CreateGameArea(byte width, byte height, byte state)
        {
            GameArea area = new GameArea(width, height, state);
            return area;
        }




        public void FillGameArea(GameArea computerArea, GameArea playerArea)
        {
            for (int i = 0; i < computerArea.GameAreaArray.GetLength(0); i++)
            {
                for (int j = 0; j < computerArea.GameAreaArray.GetLength(1); j++)
                {
                    computerArea.GameAreaArray[i, j] = 0;
                }
                for (int k = 0; k < playerArea.GameAreaArray.GetLength(1); k++)
                {
                    playerArea.GameAreaArray[i, k] = 0;
                }
            }
        }




        public Ship CreateShip(string name, byte length, bool direction)
        {
            Ship ship = new Ship(name, length, direction);
            return ship;
        }




        /// <summary>
        /// Choosing the ship from the playerShips list and returning a ship called choosenShip
        /// </summary>
        /// <param name="playerShips"></param>
        /// <returns></returns>
        public Ship ChoosePlayerShip(List<Ship> playerShips)
        {
            Ship chosenShip = null;
            switch (Console.ReadKey(true).KeyChar)
            {
                case '0':
                    chosenShip = playerShips[0];
                    break;

                case '1':
                    chosenShip = playerShips[1];
                    break;

                case '2':
                    chosenShip = playerShips[2];
                    break;

                case '3':
                    chosenShip = playerShips[3];
                    break;

                case '4':
                    chosenShip = playerShips[4];
                    break;


            }
            // chosenShip = ChooseDirection(chosenShip);

            return chosenShip;

        }



        /// <summary>
        /// Adding either true or false to the direction bool for playerShips. This one is only returning a ship
        /// </summary>
        /// <param name="playerShips"></param>
        /// <returns></returns>
        public Ship ChoosePlayershipDirection(Ship playerShips)
        {
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    playerShips.Direction = true;
                    break;

                case '2':
                    playerShips.Direction = false;
                    break;
            }
            return playerShips;

        }




        /// <summary>
        /// returning the cordinate for the X axis
        /// </summary>
        /// <returns></returns>
        public byte PlaceX()
        {
            byte xCord = 0;
            switch (Convert.ToChar(Console.ReadKey(true).KeyChar.ToString().ToUpper()))//Take both upper and over case letters. 

            {
                case 'A':
                    xCord = 0;
                    break;

                case 'B':
                    xCord = 1;
                    break;

                case 'C':
                    xCord = 2;
                    break;

                case 'D':
                    xCord = 3;
                    break;

                case 'E':
                    xCord = 4;
                    break;

                case 'F':
                    xCord = 5;
                    break;

                case 'G':
                    xCord = 6;
                    break;

                case 'H':
                    xCord = 7;
                    break;

                case 'I':
                    xCord = 8;
                    break;

                case 'J':
                    xCord = 9;
                    break;
            }
            return xCord;
        }




        /// <summary>
        /// returning the cordinate for the Y axis
        /// </summary>
        /// <returns></returns>
        public byte PlaceY()
        {
            if (true)
            {
                byte yCord = 0;
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '0':
                        yCord = 0;
                        break;

                    case '1':
                        yCord = 1;
                        break;

                    case '2':
                        yCord = 2;
                        break;

                    case '3':
                        yCord = 3;
                        break;

                    case '4':
                        yCord = 4;
                        break;

                    case '5':
                        yCord = 5;
                        break;

                    case '6':
                        yCord = 6;
                        break;

                    case '7':
                        yCord = 7;
                        break;

                    case '8':
                        yCord = 8;
                        break;

                    case '9':
                        yCord = 9;
                        break;
                }
                return yCord;
            }
        }




        public void PlacePlayerShip(GameArea playerArea, Ship playerShip)
        {
            try
            {
                if (playerArea.GameAreaArray[PlaceX(), PlaceY()] == 0)//0=empty, 1=ship, 2=ship hit, 3=not shot at, 4=already shot at
                {
                    if (playerShip.Direction == true)
                    {
                        if (playerArea.GameAreaArray.GetLength(1) - (playerArea.GameAreaArray.GetLength(1) - playerShip.Length) >= playerShip.Length)
                        {
                            byte count = 0;
                            for (int i = 0; i < playerShip.Length; i++)
                            {
                                if (playerArea.GameAreaArray[PlaceX(), PlaceY() + i] == 0)//0=empty, 1=ship, 2=ship hit, 3=not shot at, 4=already shot at
                                {
                                    count = count++;
                                }
                            }
                            if (count < playerShip.Length)
                            {
                                //Here the ship can be placed.
                                for (int i = 0; i < playerShip.Length; i++)
                                {
                                    playerArea.GameAreaArray[PlaceX(), PlaceY() + i] = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (playerArea.GameAreaArray.GetLength(0) - (playerArea.GameAreaArray.GetLength(0) - playerShip.Length) >= playerShip.Length)
                        {

                        }
                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("You can't place your ship in those cordinates");
            }
        }
        #endregion
    }
}

