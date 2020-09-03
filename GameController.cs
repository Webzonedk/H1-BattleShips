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
        public Ship ChoosePlayershipDirection(Ship playerShips)
        {
            //Program.ShowChooseDirection(); //true = horisontal - false = vertical
          // playerShips.Direction;
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

            #endregion

        }
        
        //public Ship ChooseShip(List<Ship> ships)
        //{
        //    Ship chosenShip = null;
        //    switch (Console.ReadKey(true).KeyChar)
        //    {
        //        case '1':
        //            chosenShip = ships[0];
        //            break;

        //        case '2':
        //            chosenShip = ships[1];
        //            break;

        //        case '3':
        //            chosenShip = ships[2];
        //            break;

        //        case '4':
        //            chosenShip = ships[3];
        //            break;

        //        case '5':
        //            chosenShip = ships[4];
        //            break;


        //    }
        //    chosenShip = ChooseDirection(chosenShip);

        //    return chosenShip;

        //}
        //public Ship ChooseDirection(Ship ship)
        //{
        //    Program.ShowChooseDirection(); //true = horisontal - false = vertical
        //    switch (Console.ReadKey(true).KeyChar)
        //    {
        //        case '1':
        //            ship.Direction = true;
        //            break;

        //        case '2':
        //            ship.Direction = false;
        //            break;
        //    }
        //    return ship.Direction;

        //    #endregion

        //}

        public void PlacePlayerShip()
        {
            if (true)
            {

            }
        }
    }
}

