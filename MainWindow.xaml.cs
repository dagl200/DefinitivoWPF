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
using System.Net.Sockets;
using System.ComponentModel;
using System.Threading;


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
        //public int guess, count;
        public bool singleplayer = false, multiplayer = false, beta = false;

        
       
        
        
        public MainWindow()
        {
            InitializeComponent();
           
        }

        

        public void IA_Turn()
        {
            int guess, count = 0;
            guess = modanR.Next(1, 9);
            switch (guess)
            {
                case 1:
                    if (TopLeftButn.IsEnabled) 
                    { 
                        TopLeftButn.Content = "O";
                        TopLeftButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >=9)
                        {
                            break;
                        }
                        count++;
                        goto case 2;
                    }
                    
                        break;
            
                case 2:
                    if (TopMidButn.IsEnabled)
                    {
                        TopMidButn.Content = "O";
                        TopMidButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 3;
                    }

                        break;
                case 3:
                    if (TopRightButn.IsEnabled) 
                    {
                        TopRightButn.Content = "O";
                        TopRightButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 4;
                    }

                        break;
                case 4:
                    if (MidLeftButn.IsEnabled)
                    {
                        MidLeftButn.Content = "O";
                        MidLeftButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 5;
                    }

                        break;
                case 5:
                    if (MidMidButn.IsEnabled) 
                    {
                        MidMidButn.Content = "O";
                        MidMidButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 6;
                    }

                        break;
                case 6:
                    if (MidRightButn.IsEnabled) 
                    {
                        MidRightButn.Content = "O";
                        MidRightButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 7;
                    }
   
                        break;
                case 7:
                    if (LowLeftButn.IsEnabled) 
                    {
                        LowLeftButn.Content = "O";
                        LowLeftButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 8;
                    }

                        break;
                case 8:
                    if (LowMidButn.IsEnabled) 
                    {
                        LowMidButn.Content = "O";
                        LowMidButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 9;
                    }

                        break;
                case 9:
                    if (LowRightButn.IsEnabled) 
                    {
                        LowRightButn.Content = "O";
                        LowRightButn.IsEnabled = false;
                    }
                    else
                    {
                        if (count >= 9)
                        {
                            break;
                        }
                        count++;
                        goto case 1;
                    }

                        break;
            }

            Validacion();
        }
        public bool Validacion()
        {
            if ((string)TopLeftButn.Content=="X" && (string)TopMidButn.Content=="X" && (string)TopRightButn.Content=="X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;
            }
            else if ((string)MidLeftButn.Content == "X" && (string)MidMidButn.Content == "X" && (string)MidRightButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;
            }
            else if ((string)LowLeftButn.Content == "X" && (string)LowMidButn.Content == "X" && (string)LowRightButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopLeftButn.Content == "X" && (string)MidLeftButn.Content == "X" && (string)LowLeftButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopMidButn.Content == "X" && (string)MidMidButn.Content == "X" && (string)LowMidButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopRightButn.Content == "X" && (string)MidRightButn.Content == "X" && (string)LowRightButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopLeftButn.Content == "X" && (string)MidMidButn.Content == "X" && (string)LowRightButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)LowLeftButn.Content == "X" && (string)MidMidButn.Content == "X" && (string)TopRightButn.Content == "X")
            {
                MessageBox.Show("Player 1 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopLeftButn.Content == "O" && (string)TopMidButn.Content == "O" && (string)TopRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)MidLeftButn.Content == "O" && (string)MidMidButn.Content == "O" && (string)MidRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)LowLeftButn.Content == "O" && (string)LowMidButn.Content == "O" && (string)LowRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopLeftButn.Content == "O" && (string)MidLeftButn.Content == "O" && (string)LowLeftButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopMidButn.Content == "O" && (string)MidMidButn.Content == "O" && (string)LowMidButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopRightButn.Content == "O" && (string)MidRightButn.Content == "O" && (string)LowRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)TopLeftButn.Content == "O" && (string)MidMidButn.Content == "O" && (string)LowRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)LowLeftButn.Content == "O" && (string)MidMidButn.Content == "X" && (string)TopRightButn.Content == "O")
            {
                MessageBox.Show("Player 2 Wins!");
                FreezeBoard();
                return true;

            }
            else if ((string)LowLeftButn.Content!="" && (string)LowMidButn.Content != "" && (string)LowRightButn.Content != "" && (string)MidLeftButn.Content != "" && (string)MidMidButn.Content != "" && (string)MidRightButn.Content != "" && (string)TopLeftButn.Content != "" && (string)TopMidButn.Content != "" && (string)TopRightButn.Content != "")
            {
                MessageBox.Show("It's a draw!");
                FreezeBoard();
                return true;

            }
            return false;
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
       

    }
}

