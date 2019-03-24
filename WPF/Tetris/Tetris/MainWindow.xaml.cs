using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Tetris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        Board myBoard;

        public MainWindow()
        {
            InitializeComponent();
        }

        void MainWindow_Initilized(object sender, EventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(GameTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 400);
            GameStart();
        }

        private void GameStart()
        {
            MainGrid.Children.Clear();
            myBoard = new Board(MainGrid);
            timer.Start();
        }

        private void GameTick(object sender, EventArgs e)
        {
            Score.Content = myBoard.GetScore().ToString("00");
            Lines.Content = myBoard.GetLines().ToString("00");
            myBoard.CurrentTetrominoMovDown();
        }

        private void GamePause()
        {
            if (timer.IsEnabled)
                timer.Stop();
            else
                timer.Start();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    if (timer.IsEnabled)
                        myBoard.CurrentTetrominoMovLeft();
                    break;

                case Key.Up:
                    if (timer.IsEnabled)
                        myBoard.CurrentTetrominoMovRotate();
                    break;

                case Key.Right:
                    if (timer.IsEnabled)
                        myBoard.CurrentTetrominoMovRight();
                    break;

                case Key.Down:
                    if (timer.IsEnabled)
                        myBoard.CurrentTetrominoMovDown();
                    break;

                case Key.F2:
                    GameStart();
                    break;

                case Key.F3:
                    GamePause();
                    break;

                default:
                    break;
            }
        }
    }
}
