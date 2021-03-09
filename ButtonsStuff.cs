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
    partial class MainWindow:Window
    {
        private void TopLeftButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                TopLeftButn.Content = "X";
                TopLeftButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) TopLeftButn.Content = "X";
                if (turn == player2) TopLeftButn.Content = "O";
                TopLeftButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 1 };
                TopLeftButn.Content = PlayerChar;
                TopLeftButn.IsEnabled = false;
                sock.Send(num);
                salvame(); 
            }


        }

        private void TopMidButn_Click(object sender, RoutedEventArgs e)
        {

            if (singleplayer == true)
            {
                TopMidButn.Content = "X";
                TopMidButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) TopMidButn.Content = "X";
                if (turn == player2) TopMidButn.Content = "O";
                TopMidButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 2 };
                sock.Send(num);
                TopMidButn.Content = PlayerChar;
                TopMidButn.IsEnabled = false;
                salvame();

               
            }

        }

        private void TopRightButn_Click(object sender, RoutedEventArgs e)
        {

            if (singleplayer == true)
            {
                TopRightButn.Content = "X";
                TopRightButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) TopRightButn.Content = "X";
                if (turn == player2) TopRightButn.Content = "O";
                TopRightButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 3 };
                sock.Send(num);
                TopRightButn.Content = PlayerChar;
                TopRightButn.IsEnabled = false;
                salvame();

               
            }


        }


        private void MidLeftButn_Click(object sender, RoutedEventArgs e)
        {

            if (singleplayer == true)
            {
                MidLeftButn.Content = "X";
                MidLeftButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) MidLeftButn.Content = "X";
                if (turn == player2) MidLeftButn.Content = "O";
                MidLeftButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 4 };
                sock.Send(num);
                MidLeftButn.Content = PlayerChar;
                MidLeftButn.IsEnabled = false;
                salvame();

            }

        }

        private void MidMidButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                MidMidButn.Content = "X";
                MidMidButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) MidMidButn.Content = "X";
                if (turn == player2) MidMidButn.Content = "O";
                MidMidButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 5 };
                sock.Send(num);
                MidMidButn.Content = PlayerChar;
                MidMidButn.IsEnabled = false;
                salvame();

                
            }
        }

        private void MidRightButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                MidRightButn.Content = "X";
                MidRightButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) MidRightButn.Content = "X";
                if (turn == player2) MidRightButn.Content = "O";
                MidRightButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 6 };
                sock.Send(num);
                MidRightButn.Content = PlayerChar;
                MidRightButn.IsEnabled = false;
                salvame();

               
            }
        }

        private void LowLeftButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                LowLeftButn.Content = "X";
                LowLeftButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) LowLeftButn.Content = "X";
                if (turn == player2) LowLeftButn.Content = "O";
                LowLeftButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 7 };
                LowLeftButn.Content = PlayerChar;
                LowLeftButn.IsEnabled = false;
                sock.Send(num);
                
                salvame();

               
            }
        }



        private void LowMidButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                LowMidButn.Content = "X";
                LowMidButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) LowMidButn.Content = "X";
                if (turn == player2) LowMidButn.Content = "O";
                LowMidButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 8 };
                sock.Send(num);
                LowMidButn.Content = PlayerChar;
                LowMidButn.IsEnabled = false;
                salvame();

            }
        }

        private void LowRightButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer == true)
            {
                LowRightButn.Content = "X";
                LowRightButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer == true)
            {
                if (turn == player1) LowRightButn.Content = "X";
                if (turn == player2) LowRightButn.Content = "O";
                LowRightButn.IsEnabled = false;
                Validacion();
                ChangeTurn();
            }
            if (beta == true)
            {
                byte[] num = { 9 };
                sock.Send(num);
                LowRightButn.Content = PlayerChar;
                LowRightButn.IsEnabled = false;
                salvame();

               
            }
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

            multiplayer = true;
            singleplayer = false;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            multiplayer = false;
            singleplayer = false;

            ResetBoard();

        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {

            beta = true;

            MessageBoxResult isHost = MessageBox.Show("Eres el host?", "My App", MessageBoxButton.YesNo);
            string ip = "localhost";

            if (isHost == MessageBoxResult.Yes)
            {
                PlayerChar = "X";
                OpponentChar = "O";
                server = new TcpListener(System.Net.IPAddress.Any, 5732);

                server.Start();
                sock = server.AcceptSocket();
                

            }
            else
            {
                PlayerChar = "O";
                OpponentChar = "X";
                
                
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            server.Stop();
            App.Current.Shutdown();
            
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            singleplayer = true;
            multiplayer = false;
            beta = false;
        }
        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            ReceiveMove();
            UnfreezeBoard();
        }
    }
}
