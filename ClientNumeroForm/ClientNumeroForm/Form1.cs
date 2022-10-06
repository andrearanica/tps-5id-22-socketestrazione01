using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace ClientNumeroForm {
    public partial class Form1 : Form {
        int num;
        string ip = "127.0.0.1", port = "5000";
        public Form1() {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e) {
            try {
                num = int.Parse(txt_number.Text);
            } catch (System.FormatException) {
                MessageBox.Show("Devi inserire un numero per giocare");
            }

            lbl_response.Text = "Risposta: ";

            if (txt_ip.Text != "") {
                ip = txt_ip.Text;
            } else {
                txt_ip.Text = "127.0.0.1";
                ip = txt_ip.Text;
            }
            if (txt_port.Text != ""){
                port = txt_port.Text;
            } else {
                txt_port.Text = "5000";
                port = txt_port.Text;
            }

            // Set socket
            byte[] bytes = new byte[1024];
            try {
                
                IPAddress ipAddress = System.Net.IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(port));

                Socket Sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try {
                    
                    Sender.Connect(remoteEP);
                    // MessageBox.Show("Connesso con " + Sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(num + "<EOF>");
                    int bytesSent = Sender.Send(msg);

                    int bytesRec = Sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    // MessageBox.Show("Risposta del server: " + response);
                    lbl_response.Text += response;

                    if (int.Parse(response) == num) {
                        lbl_result.Text = "Hai vinto 🥳";
                    } else {
                        lbl_result.Text = "Hai perso 😢";
                    }

                    Sender.Shutdown(SocketShutdown.Both);
                    Sender.Close();

                } catch (ArgumentNullException ane) {
                    MessageBox.Show("Errore: riprova");
                } catch (SocketException se) {
                    MessageBox.Show("Errore: prova con un altro IP");
                } catch (Exception) {
                    MessageBox.Show("Errore: riprova");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {
            if (txt_port.Text != "5000")
            {
                lbl_danger.Text = "Attenzione! Verifica l'indirizzo del server";
            }
            else
            {
                lbl_danger.Text = "";
            }
        }

        private void txt_ip_TextChanged(object sender, EventArgs e)
        {
            if (txt_ip.Text != "127.0.0.1") {
                lbl_danger.Text = "Attenzione! Verifica l'indirizzo del server";
            } else {
                lbl_danger.Text = "";
            }
        }
    }
}
