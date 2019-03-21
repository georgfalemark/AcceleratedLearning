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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 700;
            animation.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            animation.AutoReverse = true;
            animation.RepeatBehavior = new RepeatBehavior(TimeSpan.Parse("0:0:50"));
            rectangle.BeginAnimation(Canvas.LeftProperty, animation);
        }
    }
}
