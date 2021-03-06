﻿using System;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static string _socketName = "testd.sock";
    static string _linuxTempPath = "/var/tmp";
    static string _winTempPath = "%TEMP%";

    static string _socketPath;

    // C# - .NET Core 2.0 이하의 Unix Domain Socket 사용 시 System.IndexOutOfRangeException 오류
    // http://www.sysnet.pe.kr/2/0/11999


    static void Main(string[] args)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            string tempPath = Path.Combine(_winTempPath, _socketName);
            _socketPath = Environment.ExpandEnvironmentVariables(tempPath);
        }
        else
        {
            _socketPath = Path.Combine(_linuxTempPath, _socketName);
        }

        Thread.Sleep(2000);

        //while (true)
        //{
            ConnectAsClient(args);
            /*
            string txt = Console.ReadLine();
            if (txt == "q")
            {
                return;
            }
            */
        //}
    }

    private static void ConnectAsClient(string[] args)
    {
        var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
        var unixEp = new UnixDomainSocketEndPoint(_socketPath);

        // Under .NET Core 2.1, you can use user-defined UnixEndPoint type
        // var unixEp = new UnixEndPoint(_socketPath);

        socket.Connect(unixEp);
        Console.WriteLine("[Client] Conencted");

        NetworkStream networkStream = new NetworkStream(socket);
        if (networkStream.CanWrite)
        {
            
            byte[] WriteBuffer = Encoding.ASCII.GetBytes(args[0]);
            networkStream.Write(WriteBuffer, 0, WriteBuffer.Length);
        }

        socket.Close();
        Console.WriteLine("[Client] Closed");
    }
}