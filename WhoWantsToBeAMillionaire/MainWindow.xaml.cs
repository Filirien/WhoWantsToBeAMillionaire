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

namespace WhoWantsToBeAMillionaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            asd();

            if (counterRounds < 5)
            {
                Questions.Difficulty.Easy;
            }
            else if (counterRounds < 10 && counterRounds >= 5)
            {
                Questions.Difficulty.Medium;
            }
            else if (counterRounds < 15 && counterRounds >= 10)
            {
                Questions.Difficulty.Hard;
            }
        }

        private static void asd()
        {
            int a = 5;
            a = a - 2;
        }
    }
}
