using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShips
{
    class Ship
    {
        #region Field

        private string name;
        private byte length;
       private bool direction; //true = horisontal - false = vertical
        #endregion



        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte Length
        {
            get { return length; }
            set { length = value; }
        }
        public bool Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        #endregion



        #region Constructors
        public Ship()
        {

        }


        public Ship(string name, byte length,bool direction)
        {
            this.name = name;
            this.length = length;
           this.direction = direction;

        }
        #endregion


    }
}
