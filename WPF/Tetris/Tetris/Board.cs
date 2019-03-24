using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tetris
{
    public class Board
    {
        private int rows;
        private int cols;
        private int score;
        private int linesFilled;
        private TetroMino currentTetromino;
        private Label[,] blockControls;

        static private Brush noBrush = Brushes.Transparent;
        static private Brush silverBrush = Brushes.Gray;

        public Board(Grid TetrisGrid)
        {
            rows = TetrisGrid.RowDefinitions.Count;
            cols = TetrisGrid.ColumnDefinitions.Count;
            score = 0;
            linesFilled = 0;

            blockControls = new Label[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    blockControls[i, j] = new Label();
                    blockControls[i, j].Background = noBrush;
                    blockControls[i, j].BorderBrush = silverBrush;
                    blockControls[i, j].BorderThickness = new Thickness(1, 1, 1, 1);
                    Grid.SetRow(blockControls[i, j], j);
                    Grid.SetColumn(blockControls[i, j], i);
                    TetrisGrid.Children.Add(blockControls[i, j]);
                }
            }
            currentTetromino = new TetroMino();
            CurrentTetroMinoDraw();
        }
        public int GetScore()
        {
            return score;
        }
        public int GetLines()
        {
            return linesFilled;
        }
        public void CurrentTetroMinoDraw()
        {
            Point position = currentTetromino.GetCurrentPosition();

            Point[] shape = currentTetromino.GetCurrentShape();
            Brush color = currentTetromino.GetCurrentColor();

            foreach (Point S in shape)
            {
                blockControls[(int)(S.X + position.X) + ((cols / 2) - 1),
                    (int)(S.Y + position.Y) + 2].Background = color;
            }
        }
        public void CurrentTetrominoErase()
        {
            Point position = currentTetromino.GetCurrentPosition();

            Point[] shape = currentTetromino.GetCurrentShape();

            foreach (Point S in shape)
            {
                blockControls[(int)(S.X + position.X) + ((cols / 2) - 1),
                    (int)(S.Y + position.Y) + 2].Background = noBrush;
            }
        }
        public void CheckRow()
        {
            bool full;
            for (int i = rows - 1; i > 0; i--)
            {
                full = true;
                for (int j = 0; j < cols; j++)
                {
                    if (blockControls[j, i].Background == noBrush)
                    {
                        full = false;
                    }
                }

                if (full)
                {
                    RemoveRows(i);
                    score += 100;
                    linesFilled += 1;
                }
            }
        }
        public void RemoveRows(int row)
        {
            for (int i = row; i > 2; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    blockControls[j, i].Background = blockControls[j, i - 1].Background;
                }
            }
        }
        public void CurrentTetrominoMovLeft()
        {
            Point position = currentTetromino.GetCurrentPosition();
            Point[] shape = currentTetromino.GetCurrentShape();
            bool move = true;
            CurrentTetrominoErase();
            foreach (Point S in shape)
            {
                if (((int)(S.X + position.X) + ((cols / 2) - 1) - 1) < 0)
                {
                    move = false;
                }
                else if (blockControls[((int)(S.X + position.X) + ((cols / 2) - 1) - 1), 
                    (int)(S.Y + position.Y) + 2].Background != noBrush)
                {
                    move = false;
                }
            }

            if (move)
            {
                currentTetromino.MovLeft();
                CurrentTetroMinoDraw();
            }
            else
            {
                CurrentTetroMinoDraw();
            }
        }
        public void CurrentTetrominoMovRight()
        {
            Point position = currentTetromino.GetCurrentPosition();
            Point[] shape = currentTetromino.GetCurrentShape();
            bool move = true;
            CurrentTetrominoErase();

            foreach (Point S in shape)
            {
                if (((int)(S.X + position.X) + ((cols / 2) - 1) + 1 ) >= cols)
                {
                    move = false;
                }
                else if (blockControls[((int)(S.X + position.X) + ((cols / 2) - 1) + 1 ), 
                    (int)(S.Y + position.Y) + 2].Background != noBrush)
                {
                    move = false;
                }
            }

            if (move)
            {
                currentTetromino.MovRight();
                CurrentTetroMinoDraw();
            }
            else
            {
                CurrentTetroMinoDraw();
            }
        }
        public void CurrentTetrominoMovDown()
        {
            Point position = currentTetromino.GetCurrentPosition();
            Point[] shape = currentTetromino.GetCurrentShape();
            bool move = true;
            CurrentTetrominoErase();


            foreach (Point S in shape)
            {
                if (((int)(S.Y + position.Y) + 2 + 1) >= rows)
                {
                    move = false;
                }
                else if (blockControls[((int)(S.X + position.X) + ((cols / 2) - 1)),
                    (int)(S.Y + position.Y) + 2 + 1].Background != noBrush)
                {
                    move = false;
                }
            }

            if (move)
            {
                currentTetromino.MovDown();
                CurrentTetroMinoDraw();
            }
            else
            {
                CurrentTetroMinoDraw();
                CheckRow();
                currentTetromino = new TetroMino();
            }
        }
        public void CurrentTetrominoMovRotate()
        {
            Point position = currentTetromino.GetCurrentPosition();
            Point[] s = new Point[4];
            Point[] shape = currentTetromino.GetCurrentShape();
            bool move = true;
            shape.CopyTo(s, 0);
            CurrentTetrominoErase();

            for (int i = 0; i < s.Length; i++)
            {
                double x = s[i].X;
                s[i].X = s[i].Y * -1;
                s[i].Y = x;

                if (((int)((s[i].Y + position.Y) + 2)) >= rows)
                {
                    move = false;
                }
                else if (((int)(s[i].X + position.X) + (cols / 2) - 1) < 0)
                {
                    move = false;
                }
                else if (((int)(s[i].X + position.X) + ((cols / 2) - 1)) >= rows)
                {
                    move = false;
                }
                else if (blockControls[((int)(s[i].X + position.X) + ((cols / 2) - 1)), (int)(s[i].Y + position.Y) + 2].Background != noBrush)
                {
                    move = false;
                }
            }
            if (move)
            {
                currentTetromino.MovRotate();
                CurrentTetroMinoDraw();
            }
            else
            {
                CurrentTetroMinoDraw();
            }

        }
    }
}
