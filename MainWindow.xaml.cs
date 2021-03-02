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

namespace DefinitivoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string player1 = "Yo";
        public const string player2 = "Tu";
        public string turn = player1;
        public Random modanR = new Random();
        public int guess;


        public MainWindow()
        {
            InitializeComponent();

        }
        public void IA_Turn()
        {
            if (turn == player2)
            {
                guess = modanR.Next(1, 9);
                switch (guess)
                {
                    case 1:
                        if (TopLeftButn.IsEnabled) TopLeftButn.Content = "O";
                        else goto case 2;
                        break;
                    case 2:
                        if (TopMidButn.IsEnabled) TopMidButn.Content = "O";
                        else goto case 3;
                        break;
                    case 3:
                        if (TopRightButn.IsEnabled) TopRightButn.Content = "O";
                        else goto case 4;
                        break;
                    case 4:
                        if (MidLeftButn.IsEnabled) MidLeftButn.Content = "O";
                        else goto case 5;
                        break;
                    case 5:
                        if (MidMidButn.IsEnabled) MidMidButn.Content = "O";
                        else goto case 6;
                        break;
                    case 6:
                        if (MidRightButn.IsEnabled) MidRightButn.Content = "O";
                        else goto case 7;
                        break;
                    case 7:
                        if (LowLeftButn.IsEnabled) LowLeftButn.Content = "O";
                        else goto case 8;
                        break;
                    case 8:
                        if (LowMidButn.IsEnabled) LowMidButn.Content = "O";
                        else goto case 9;
                        break;
                    case 9:
                        if (LowRightButn.IsEnabled) LowRightButn.Content = "O";
                        else goto case 1;
                        break;
                }

            }
        }
        private void ChangeTurn()
        {
            if (turn == player1)
            {
                turn = player2;
            }
            else
            {
                turn = player1;
            }


        }
        private void TopLeftButn_Click(object sender, RoutedEventArgs e)
        {
            switch (turn)
            {
                case player1:
                    TopLeftButn.Content = "X";
                    break;
                case player2:
                    TopLeftButn.Content = "O";
                    break;
            }
            ChangeTurn();
            TopLeftButn.IsEnabled = false;

        }

        private void TopMidButn_Click(object sender, RoutedEventArgs e)
        {
            switch (turn)
            {
                case player1:
                    TopMidButn.Content = "X";
                    break;
                case player2:
                    TopMidButn.Content = "O";
                    break;
            }
            ChangeTurn();
            TopMidButn.IsEnabled = false;
        }

        private void TopRightButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) TopRightButn.Content = "X";
            if (turn == player2) TopRightButn.Content = "O";
            ChangeTurn();
            TopRightButn.IsEnabled = false;
        }

        private void MidLeftButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) MidLeftButn.Content = "X";
            if (turn == player2) MidLeftButn.Content = "O";
            ChangeTurn();
            MidLeftButn.IsEnabled = false;
        }

        private void MidMidButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) MidMidButn.Content = "X";
            if (turn == player2) MidMidButn.Content = "O";
            ChangeTurn();
            MidMidButn.IsEnabled = false;
        }

        private void MidRightButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) MidRightButn.Content = "X";
            if (turn == player2) MidRightButn.Content = "O";
            ChangeTurn();
            MidRightButn.IsEnabled = false;
        }

        private void LowLeftButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) LowLeftButn.Content = "X";
            if (turn == player2) LowLeftButn.Content = "O";
            ChangeTurn();
            LowLeftButn.IsEnabled = false;
        }

        private void LowMidButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) LowMidButn.Content = "X";
            if (turn == player2) LowMidButn.Content = "O";
            ChangeTurn();
            LowMidButn.IsEnabled = false;
        }

        private void LowRightButn_Click(object sender, RoutedEventArgs e)
        {
            if (turn == player1) LowRightButn.Content = "X";
            if (turn == player2) LowRightButn.Content = "O";
            ChangeTurn();
            LowRightButn.IsEnabled = false;
        }
    }
}

