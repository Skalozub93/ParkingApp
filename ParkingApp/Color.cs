using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    internal struct Color
    {
        private int red;
        private int green;
        private int blue;

        private int opacity;
       
        /// <summary>
        /// Constructor for red, green, blue, opacity values
        /// </summary>
        /// <param name="_red"></param>
        /// <param name="_green"></param>
        /// <param name="_blue"></param>
        /// <param name="_opacity"></param>
        public Color(int _red, int _green, int _blue, int _opacity)
        {
            this.red = _red;
            this.green = _green;
            this.blue = _blue;
            this.opacity = _opacity;
        }
        
        /// <summary>
        /// Method for work with "red" component of class 
        /// </summary>
        public int Red
        {
            get { return this.red; }
            set => SetRange();
        }

        /// <summary>
        /// Method for work with "green" component of class 
        /// </summary>
        public int Green
        {
            get { return this.green; }
            set => SetRange();
        }

        /// <summary>
        /// Method for work with "blue" component of class 
        /// </summary>
        public int Blue
        {
            get { return this.blue; }
            set => SetRange();
        }
        
        /// <summary>
        /// Method for work with opacity at the R,G,B
        /// </summary>
        public int Opacity
        {
            get => this.opacity;
            set => SetRange();            
        }

        /// <summary>
        /// The method limits input number and does not allow for mistakes
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void SetRange()
        {
            if(this.red < 0 || this.red > 255
                || this.green < 0 || this.green > 255
                || this.blue < 0 || this.blue > 255
                || this.opacity < 0 || this.opacity > 100)
            {
                throw new Exception("Sorry, the inputed number is incorrect\n try again!");
            }
            
        }
    }
}
