using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using NBitcoin.Crypto;
using NBitcoin.BitcoinCore;
using NBitcoin.RPC;

namespace C04_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random private key
            var privateKey = new Key();
            BitcoinSecret mainNetPrivateKey = privateKey.GetBitcoinSecret(Network.Main);

            // Anmerkung anscheinend stellt das Framework nur den Private key in Wif Format zur Verfügung!
            // TODO finde heraus wie du zum Private Key in Hex und Dezimal Format kommen kannst. (Wie im Buch mit dem Python Framework)
            //Console.WriteLine($"Main Network Private Key in Hex: {mainNetPrivateKey}");
            //Console.WriteLine($"Main Network Private Key in decimal: {mainNetPrivateKey.ToBytes()}");

            // Convert private key to Wif format
            Console.WriteLine($"Main Network Private Key in Wif Format: {mainNetPrivateKey.ToWif()}");

            Console.WriteLine(mainNetPrivateKey.IsCompressed);

            // Todos ab Seite 77 ff
            // TODO: private key in hex Format Buch Seite 77 ff

            // TODO: private key in decimal
            // TODO: private key in Wif - ist wahrscheinlich bereits in Wif formatiert
            // TODO: private key komprimieren mit + 01 Suffix
            // TODO: private key compressed und in hex
            // TODO: Multiply the EC generator point G with the private key to get a public key point

            // Public Key
            // TODO: Encode public key as hex, prefix 04
            // TODO: Compress public key, adjust prefix depending on whether y is even or odd

            // Address
            // TODO: Generate bitcoin address from public key
            // TODO: Generate compressed bitcoin address from compressed public key
        }
    }
}
