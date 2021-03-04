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
        public int guess, count;
        public bool singleplayer = false, multiplayer = false, beta = false;

        public string PlayerChar;
        public string OpponentChar;
        public Socket sock;
        public  BackgroundWorker MessageReceiver = new BackgroundWorker();
         
        public TcpListener server = null;
        public TcpClient client;
        
        
        public MainWindow()
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            
        }

        public void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {

            Validacion();
            FreezeBoard();
            ReceiveMove();
            UnfreezeBoard();
            

            
        }
        public void salvame()
        {
            Validacion();
            FreezeBoard();
            ReceiveMove();
            UnfreezeBoard();
            
        }

        public void FreezeBoard()
        {
            TopLeftButn.IsEnabled = false;
            TopRightButn.IsEnabled = false;
            TopMidButn.IsEnabled = false;
            MidLeftButn.IsEnabled = false;
            MidMidButn.IsEnabled = false;
            MidRightButn.IsEnabled = false;
            LowLeftButn.IsEnabled = false;
            LowMidButn.IsEnabled = false;
            LowRightButn.IsEnabled = false;
        }

        public void UnfreezeBoard()
        {
            if ((string)TopLeftButn.Content == "") TopLeftButn.IsEnabled = true;
            if ((string)TopMidButn.Content == "") TopMidButn.IsEnabled = true;
            if ((string)TopRightButn.Content == "") TopRightButn.IsEnabled = true;
            if ((string)MidLeftButn.Content == "") MidLeftButn.IsEnabled = true;
            if ((string)MidMidButn.Content == "") MidMidButn.IsEnabled = true;
            if ((string)MidRightButn.Content == "") MidRightButn.IsEnabled = true;
            if ((string)LowLeftButn.Content == "") LowLeftButn.IsEnabled = true;
            if ((string)LowMidButn.Content == "") LowMidButn.IsEnabled = true;
            if ((string)LowRightButn.Content == "") LowRightButn.IsEnabled = true;

        }

        public void ResetBoard() 
        {
            TopLeftButn.Content ="";
            TopRightButn.Content ="";
            TopMidButn.Content ="";
            MidLeftButn.Content ="";
            MidMidButn.Content ="";
            MidRightButn.Content ="";
            LowLeftButn.Content ="";
            LowMidButn.Content ="";
            LowRightButn.Content = "";
            UnfreezeBoard();
        }

        public void ReceiveMove()
        {
            
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
                TopLeftButn.Content = OpponentChar;
            if (buffer[0] == 2)
                TopMidButn.Content = OpponentChar;
            if (buffer[0] == 3)
                TopRightButn.Content = OpponentChar;
            if (buffer[0] == 4)
                MidLeftButn.Content = OpponentChar;
            if (buffer[0] == 5)
                MidMidButn.Content = OpponentChar;
            if (buffer[0] == 6)
                MidRightButn.Content = OpponentChar;
            if (buffer[0] == 7)
                LowLeftButn.Content = OpponentChar;
            if (buffer[0] == 8)
                LowMidButn.Content = OpponentChar;
            if (buffer[0] == 9)
                LowRightButn.Content = OpponentChar;
        }


        public void IA_Turn()
        {
            
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
                        if (count>=9)
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
        private void TopLeftButn_Click(object sender, RoutedEventArgs e)
        {
            if (singleplayer==true)
            {
                TopLeftButn.Content = "X";
                TopLeftButn.IsEnabled = false;
                Validacion();
                IA_Turn();
            }
            if (multiplayer==true)
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
                sock.Send(num);
                TopLeftButn.Content = PlayerChar;
                salvame();
                MessageReceiver.RunWorkerAsync();
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
                salvame();

                MessageReceiver.RunWorkerAsync();
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
                salvame();

                MessageReceiver.RunWorkerAsync();
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
                MessageReceiver.RunWorkerAsync();
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
                salvame();

                MessageReceiver.RunWorkerAsync();
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
                salvame();

                MessageReceiver.RunWorkerAsync();
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
                sock.Send(num);
                LowLeftButn.Content = PlayerChar;
                salvame();

                MessageReceiver.RunWorkerAsync();
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            
            multiplayer = true;
            singleplayer = false;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            ResetBoard();

        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            
            beta = true;

            MessageBoxResult isHost = MessageBox.Show("Eres el host?", "My App",MessageBoxButton.YesNo);
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
                ;
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
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
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            singleplayer = true;
            multiplayer = false;
            beta = false;
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
                MessageReceiver.RunWorkerAsync();
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
                salvame();

                MessageReceiver.RunWorkerAsync();
            }
        }

    }
}

