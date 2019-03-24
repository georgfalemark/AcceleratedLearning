using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Tetris
{
    public class TetroMino
    {
        private Point currentPosition;
        private Point[] currentShape;
        private Brush currentColor;
        private bool rotate;

        public TetroMino()
        {
            currentPosition = new Point(0, 0);
            currentColor = Brushes.Transparent;
            currentShape = SetRandomShape();
        }

        public Brush GetCurrentColor()
        {
            return currentColor;
        }

        public Point GetCurrentPosition()
        {
            return currentPosition;
        }

        public Point[] GetCurrentShape()
        {
            return currentShape;
        }

        public void MovLeft()
        {
            currentPosition.X -= 1;
        }

        public void MovRight()
        {
            currentPosition.X += 1;
        }

        public void MovDown()
        {
            currentPosition.Y += 1;
        }

        public void MovRotate()
        {
            if (rotate)
            {
                for (int i = 0; i < currentShape.Length; i++)
                {
                    double x = currentShape[i].X;
                    currentShape[i].X = currentShape[i].Y * -1;
                    currentShape[i].Y = x;
                }
            }
        }

        public Point[] SetRandomShape()
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 7) % 7)
            {
                case 0:
                    rotate = true;
                    currentColor = Brushes.Red;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(1, 0),
                        new Point(2, 0)};
                case 1:
                    rotate = true;
                    currentColor = Brushes.Black;
                    return new Point[] {
                        new Point(1, -1),
                        new Point(-1, 0),
                        new Point(0, 0),
                        new Point(1, 0)};
                case 2:
                    rotate = true;
                    currentColor = Brushes.Blue;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(1, 0),
                        new Point(1, -1)};
                case 3:
                    rotate = false;
                    currentColor = Brushes.Salmon;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(0, 1),
                        new Point(1, 0),
                        new Point(1, 1)};
                case 4:
                    rotate = true;
                    currentColor = Brushes.Green;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(0, -1),
                        new Point(1, 0)};
                case 5:
                    rotate = true;
                    currentColor = Brushes.Brown;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(0, -1),
                        new Point(1, 0)};
                case 6:
                    rotate = true;
                    currentColor = Brushes.Orange;
                    return new Point[] {
                        new Point(0, 0),
                        new Point(-1, 0),
                        new Point(0, 1),
                        new Point(1, 1)};
                default:
                    return null;
            }
            throw new Exception();
        }
    }
}
