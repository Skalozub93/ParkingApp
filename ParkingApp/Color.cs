using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    internal struct Color
    {
        private int _red;
        private int _green;
        private int _blue;

        private int _opacity;
             
        /// <summary>
        /// Constructor for red, green, blue, opacity values
        /// </summary>
        /// <param name="_red"></param>
        /// <param name="_green"></param>
        /// <param name="_blue"></param>
        /// <param name="_opacity"></param>
        public Color(int red, int green, int blue, int opacity)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
            this._opacity = opacity;
        }

        /// <summary>
        /// C-ctor with 2 paramaters 
        /// </summary>
        /// <param name="red"></param>
        /// <param name="opacity"></param>
        public Color(int red, int opacity)
        {
            _red = red;
            _green = default;
            _blue = default;
            _opacity = opacity;
        }

        /// <summary>
        /// C-ctor with 3 parameters
        /// </summary>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="opacity"></param>
        public Color(int green, int blue, int opacity)
        {
            _red = default;
            _green = green;
            _blue = blue;
            _opacity = opacity;
        }
        
        /// <summary>
        /// Method for work with "red" component of class 
        /// </summary>
        public int Red
        {
            get { return this._red; }
            set => IsColorValid(value);
        }

        /// <summary>
        /// Method for work with "green" component of class 
        /// </summary>
        public int Green
        {
            get { return this._green; }
            set => IsColorValid(value);
        }

        /// <summary>
        /// Method for work with "blue" component of class 
        /// </summary>
        public int Blue
        {
            get { return this._blue; }
            set => IsColorValid(value);
        }
        
        /// <summary>
        /// Method for work with opacity at the R,G,B
        /// </summary>
        public int Opacity
        {
            get => this._opacity;
            set => IsColorValid(value);            
        }

        /// <summary>
        /// The method limits input number and does not allow for mistakes
        /// </summary>
        /// <exception cref="Exception"></exception>
        public bool IsColorValid(int val)
        {
            if(val < 0 || val > 255)
            {
                return false;
            }
            return true;
            
        }
    }
}
