using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.miniServer;
using Common;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("192.168.206.133", 6688);//修改过
            server.Start();
            Console.ReadKey();
        }
    }
}

