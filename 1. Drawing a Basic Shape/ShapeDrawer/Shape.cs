﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{


    public class Shape
    {
        // we are declaring the private fields here 
        private Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;

        // we are delcaring the public properties here as each of them will be able to write and read
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }


        // we are declaring the constructor here which will initialize all the values with default values

        public Shape()
        {
            _color = Color.Green;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;

        }

        

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y, _width, _height);
        }

        public Boolean IsAt(Point2D pt)
        {

            if ((pt.X >= X) && (pt.X <= X + Width) && (pt.Y >= Y) && (pt.Y <= Y + Height))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
