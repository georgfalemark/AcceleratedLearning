using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MarkType[] mResults;
        private bool mPlayer1Turn;
        private bool mGameEnded;

        //Constructor, startar skärmen
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            mResults = new MarkType[9];

            for (int i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            mPlayer1Turn = true;
            Container.Children.Cast<Button>().ToList().ForEach(button => { button.Content = string.Empty; button.Background = Brushes.White; });
            mGameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnded)
            {
                NewGame();
                return;
            }

            //Hämtar knappen och skapar en instans av den. Vi hämtar 'sender'
            var button = (Button)sender;

            //Hämtar vilken kolumn den sitter i
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);

            var index = column + (row * 3);

            if (mResults[index] != MarkType.Free)
                return;

            if (mPlayer1Turn)
                mResults[index] = MarkType.Cross;
            else
                mResults[index] = MarkType.Nought;

            if (mPlayer1Turn)
            {
                button.Content = "X";
                mPlayer1Turn = false;
            }
            else
            {
                button.Content = "O";
                mPlayer1Turn = true;
            }

            CheckForWinner();


        }

        private void CheckForWinner()
        {

            //Rad 1 horizontellt
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                mGameEnded = true;
                ButC1R1.Background = ButC2R1.Background = ButC3R1.Background = Brushes.Green;
            }

            //Rad 2 horizontellt
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                mGameEnded = true;
                ButC1R2.Background = ButC2R2.Background = ButC3R2.Background = Brushes.Green;
            }

            //Rad 3 horizontellt
            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                mGameEnded = true;
                ButC1R3.Background = ButC2R3.Background = ButC3R3.Background = Brushes.Green;
            }

            //Rad 1 vertikalt
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                mGameEnded = true;
                ButC1R1.Background = ButC1R2.Background = ButC1R3.Background = Brushes.Green;
            }

            //Rad 2 vertikalt
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                mGameEnded = true;
                ButC2R1.Background = ButC2R2.Background = ButC2R3.Background = Brushes.Green;
            }

            //Rad 3 vertikalt
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                mGameEnded = true;
                ButC3R1.Background = ButC3R2.Background = ButC3R3.Background = Brushes.Green;
            }

            //Kryss start kolumn1Rad1
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                mGameEnded = true;
                ButC1R1.Background = ButC2R2.Background = ButC3R3.Background = Brushes.Green;
            }

            //Kryss start kolumn3Rad1
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                mGameEnded = true;
                ButC3R1.Background = ButC2R2.Background = ButC1R3.Background = Brushes.Green;
            }

            //Om ingen skulle vinna 
            if (!mResults.Any(result => result == MarkType.Free))
            {
                mGameEnded = true;
                Container.Children.Cast<Button>().ToList().ForEach(button => { button.Background = Brushes.Orange; });
            }

        }
    }
}
