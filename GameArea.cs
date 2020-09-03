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
        private byte[,] gameAreaArray;
        private byte state;
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
        public byte State
        {
            get { return state; }
            set { state = value; }
        }


        #endregion



        #region Constructors
        public GameArea()
        {

        }


        public GameArea(byte width, byte height,byte state )
        {
            this.width = width;
            this.height = height;
            this.gameAreaArray = new byte[width, height];
            this.state = state;

        }
        #endregion


    }
}
