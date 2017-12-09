using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using NBitcoin.RPC;
using NBitcoin.JsonConverters;
using NBitcoin.Protocol;

namespace C03_Basic_Api_Calls_NBitcoin01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 3-3. Running getinfo via Bitcoin Core’s JSON-RPC API - Seite 49
            // Benutze den RPC Wrapper von NBitcoin:
            NetworkCredential myCredential = new NetworkCredential("bitcoinrpc", "d0n7Blue");
            Uri myUri = new Uri("http://localhost.:8332/");
            RPCClient myClient = new RPCClient(myCredential, myUri);
            int blockheight = myClient.GetBlockCount();
            Console.WriteLine($"Anzahl Blöcke/Blockheight: {blockheight}");

        }
    }
}
