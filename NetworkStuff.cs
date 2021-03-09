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
        public string PlayerChar;
        public string OpponentChar;
        public Socket sock;
        

        public TcpListener server = null;
        public TcpClient client;
        
        
        public void salvame()
        {
            
            Validacion();
            FreezeBoard();

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
            TopLeftButn.Content = "";
            TopRightButn.Content = "";
            TopMidButn.Content = "";
            MidLeftButn.Content = "";
            MidMidButn.Content = "";
            MidRightButn.Content = "";
            LowLeftButn.Content = "";
            LowMidButn.Content = "";
            LowRightButn.Content = "";
            UnfreezeBoard();
        }

        public void ReceiveMove()
        {
            
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0] == 1)
            {
                TopLeftButn.Content = OpponentChar;
                TopLeftButn.IsEnabled = false;

            }
            if (buffer[0] == 2)
            {
                TopMidButn.Content = OpponentChar;
                TopMidButn.IsEnabled = false;
            }
            if (buffer[0] == 3)
            {
                TopRightButn.Content = OpponentChar;
                TopRightButn.IsEnabled = false;
            }
            if (buffer[0] == 4)
            {
                MidLeftButn.Content = OpponentChar;
                MidLeftButn.IsEnabled = false;
            }
            if (buffer[0] == 5)
            {
                MidMidButn.Content = OpponentChar;
                MidMidButn.IsEnabled = false;
            }
            if (buffer[0] == 6)
            {
                MidRightButn.Content = OpponentChar;
                MidRightButn.IsEnabled = false;
            }
            if (buffer[0] == 7)
            {
                LowLeftButn.Content = OpponentChar;
                LowLeftButn.IsEnabled = false;
            }
            if (buffer[0] == 8)
            {
                LowMidButn.Content = OpponentChar;
                LowMidButn.IsEnabled = false;
            }
            if (buffer[0] == 9)
            {
                LowRightButn.Content = OpponentChar;
                LowRightButn.IsEnabled = false;
            }
        }
    }
}
