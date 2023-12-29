﻿using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawer
{
    public class Drawing
    {
        private List<Shape> _shapes;
        private Color _background;

        public int ShapeCount
        {
            get { return _shapes.Count; }
        }
        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();

                foreach (Shape s in _shapes)
                    if (s.Selected)
                        result.Add(s);

                return result;
            }
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public Drawing() : this(Color.White) { }

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            Background = background;
        }
     

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);

            foreach (Shape shape in _shapes)
                shape.Draw();
        }

      
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.IsAt(pt))
                    shape.Selected = true;
                else 
                    shape.Selected = false;
            }
        }


    }
}
