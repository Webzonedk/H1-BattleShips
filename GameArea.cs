using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    class GameArea
    {
        #region Field

        private byte height;
        private byte width;
        private byte[,] gameAreaArray;//0=empty, 1=ship, 2=ship hit, 3=not shot at, 4=already shot at
        //private byte state; //0=empty, 1=ship, 2=ship hit
        //private bool shotState; //0=not shot at, 2=already shot at
        #endregion



        #region Properties
        public byte Height
        {
            get { return height; }
            set { height = value; }
        }
        public byte Width
        {
            get { return width; }
            set { width = value; }
        }
        public byte[,] GameAreaArray
        {
            get { return gameAreaArray; }
            set { gameAreaArray = value; }
        }
        //public byte State
        //{
        //    get { return state; }
        //    set { state = value; }
        //}
        //public bool ShotState
        //{
        //    get { return shotState; }
        //    set { shotState = value; }
        //}


        #endregion



        #region Constructors
        public GameArea()
        {

        }


        public GameArea(byte width, byte height, byte state)
        {
            this.width = width;
            this.height = height;
            this.gameAreaArray = new byte[width, height];
            ////this.state = state;
            //this.shotState = shotState;

        }
        #endregion


    }
}
