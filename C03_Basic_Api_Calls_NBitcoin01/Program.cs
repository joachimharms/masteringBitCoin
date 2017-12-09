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

            // Example 3-4. Retrieving a transaction and iterating its outputs
            // Alice's transaction ID
            NBitcoin.uint256 txid = uint256.Parse("0627052b6f28912f2703066a912ea577f2ce4da4caa5a5fbd8a57286c345c2f2");

            // First, retrieve the raw transaction in hex
            string raw_tx = myClient.GetRawTransaction(txid).ToString();
            Console.WriteLine(raw_tx);


            // Decode the transaction hex into a JSON object
            //Transaction decodedTx = myClient.DecodeRawTransactionAsync(raw_tx);
            //Transaction decodedTx = myClient.DecodeRawTransaction(raw_tx);
            //Console.WriteLine(raw_tx);

            //var outputList = raw_tx.Outputs;
            //foreach (var output in outputList)
            //{
            //    Console.WriteLine(output);
            //}



            // Example 3-5. Retrieving a block and adding all the transaction outputs - Seite 50
            int blockheightOfAliceTransaction = 277316;

            // Get the block hash of block with height 277316
            var blockhash = myClient.GetBlockHash(blockheightOfAliceTransaction);

            // Retrieve the block by its hash
            var block = myClient.GetBlock(blockhash);
            var listOfTransactions = block.Transactions;
            Console.WriteLine($"blockheight of Alice's Transaction: {blockheightOfAliceTransaction}\n Blockhash: {blockhash}\n");
            NBitcoin.Money sumOfTrans = 0;
            foreach (var trans in listOfTransactions)
            {
                sumOfTrans += trans.TotalOut;
            }
            // Die Summe stimmt! Siehe Seite 51:
            Console.WriteLine($"Bitcoin Wert insgesamt des Blocks: {sumOfTrans.ToString()}");



        }
    }
}
