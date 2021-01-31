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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            Game var = new Game();
            Hide();
            var.Show();
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi welcome to BlackJack! The rules are simple. You will first be given 2 cards. The goal of the game is to get as close to 21 as possible by adding up your card values. You can press the hit button to get another card but be careful, you don't want to go over 21 or you lose. PS face cards are worth 10 points. Aces can count as either 1 or 11! If you need more help, there is another help button on the game screen. Good luck!");
        }

        private void Exitbtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
