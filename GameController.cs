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




        public Ship CreateShip(string name, byte length, byte hit, bool direction)
        {
            Ship ship = new Ship(name, length, hit, direction);
            return ship;
        }




        /// <summary>
        /// Choosing the ship from the playerShips list and returning a ship called choosenShip
        /// </summary>
        /// <param name="playerShips"></param>
        /// <returns></returns>
        public Ship ChoosePlayerShipOld(List<Ship> ships, List<Ship> playerShips)
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
        /// 
        /// </summary>
        /// <param name="ships"></param>
        /// <param name="playerShips"></param>
        /// <returns></returns>
        public Ship ChoosePlayerShip(List<Ship> ships, List<Ship> playerShips)//added ships for an experiment
        {
            try
            {

                byte pick = Convert.ToByte(Console.ReadKey(true).KeyChar);
                Ship chosenShip = null;
                for (byte i = 0; i < ships.Count; i++)
                {
                    if (pick == i)
                    {
                        chosenShip = playerShips[i];
                    }



                    // chosenShip = ChooseDirection(chosenShip);

                }
                return chosenShip;
            }

            catch (Exception)
            {

                Program.PleasePickTheRightNumber();
            }
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
        /// returning the cordinate and the Carecter to show for the X axis by using a Tuple to return multiple variables og different kinds
        /// </summary>
        /// <returns></returns>
        public Tuple<byte, string> PlaceX(byte xCord, string xCordChar)
        {
            //xCord = 0;
            switch (Convert.ToChar(Console.ReadKey(true).KeyChar.ToString().ToUpper()))//Take both upper and over case letters. 

            {
                case 'A':
                    xCord = 0;
                    xCordChar = "A";
                    break;

                case 'B':
                    xCord = 1;
                    xCordChar = "B";
                    break;

                case 'C':
                    xCord = 2;
                    xCordChar = "C";
                    break;

                case 'D':
                    xCord = 3;
                    xCordChar = "D";
                    break;

                case 'E':
                    xCord = 4;
                    xCordChar = "E";
                    break;

                case 'F':
                    xCord = 5;
                    xCordChar = "F";
                    break;

                case 'G':
                    xCord = 6;
                    xCordChar = "G";
                    break;

                case 'H':
                    xCord = 7;
                    xCordChar = "H";
                    break;

                case 'I':
                    xCord = 8;
                    xCordChar = "I";
                    break;

                case 'J':
                    xCord = 9;
                    xCordChar = "J";
                    break;
            }
            return new Tuple<byte, string>(xCord, xCordChar);

        }




        /// <summary>
        /// returning the cordinate for the Y axis
        /// </summary>
        /// <returns></returns>
        public byte PlaceY(byte yCord)
        {

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




        public void PlacePlayerShip(GameArea playerArea, Ship choosenPlayerShip, List<Ship> ships, List<Ship> playerShips, byte xCord, byte yCord)
        {
            try
            {
                if (playerArea.GameAreaArray[xCord, yCord] == 0)//0=empty, 1=ship, 2=ship hit, 3=not shot at, 4=already shot at
                {
                    if (choosenPlayerShip.Direction == true)
                    {
                        if (playerArea.GameAreaArray.GetLength(1) - (playerArea.GameAreaArray.GetLength(1) - choosenPlayerShip.Length) >= choosenPlayerShip.Length)
                        {
                            byte count = 0;
                            for (int i = 0; i < choosenPlayerShip.Length; i++)
                            {
                                if (playerArea.GameAreaArray[xCord, yCord + i] == 0)//0=empty, 1=ship, 2=ship hit, 3=not shot at, 4=already shot at
                                {
                                    count = count++;
                                }
                            }
                            if (count < choosenPlayerShip.Length)
                            {
                                //Here the ship can be placed.
                                for (int i = 0; i < choosenPlayerShip.Length; i++)
                                {
                                    playerArea.GameAreaArray[xCord, yCord + i] = 1;
                                }
                                playerShips.Add(choosenPlayerShip);
                                ships.Remove(choosenPlayerShip);
                            }
                        }
                    }
                    else
                    {
                        if (playerArea.GameAreaArray.GetLength(0) - (playerArea.GameAreaArray.GetLength(0) - choosenPlayerShip.Length) >= choosenPlayerShip.Length)
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

