using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class ServerNumeroRandom
{
    public static string data = null;       // Testo del client
    public static string ip, port;
    public static void StartListening (int d)
    {
        byte[] bytes = new Byte[1024];
 
        IPAddress ipAddress = System.Net.IPAddress.Parse(ip);
        IPEndPoint localEndPoint = new IPEndPoint(ipAddress, int.Parse(port));

        Socket listener = new Socket(ipAddress.AddressFamily,
            SocketType.Stream, ProtocolType.Tcp);

        try {
            listener.Bind(localEndPoint);
            listener.Listen(10);

            while (true) {
                Console.WriteLine("Aspetto una connessione...");
                Socket handler = listener.Accept();
                data = null;

                while (true) {
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1) {
                        break;
                    }
                }

                Console.WriteLine("Testo ricevuto : {0}", data);

                int n = new Random().Next(1, 9);
                switch (d) {
                    case 1:
                        n = new Random().Next(1, 9);
                        break;
                    case 2:
                        n = new Random().Next(1, 19);
                        break;
                    case 3:
                        n = new Random().Next(1, 29);
                        break;
                }

                handler.Send(Encoding.ASCII.GetBytes(n.ToString()));
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }

        }
        catch (Exception e) {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\nPress ENTER to continue...");
        Console.Read();
    }

    public static int Main (String[] args)
    {
        Console.Write("Configura il server (IP PORT) (invio per impostazioni di default) \n>");
        string conf = Console.ReadLine();
        if (conf != "") {
            string[] stats = conf.Split(' ');
            ip = stats[0]; port = stats[1];
        } else {
            ip = "127.0.0.1";
            port = "5000";
        }
        Console.Write("Inserisci la difficoltà (1, 2, 3) \n>");
        int d = int.Parse(Console.ReadLine());
        StartListening(d);
        return 0;
    }
}