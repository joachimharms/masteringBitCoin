using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBitcoin;

namespace MyBitcoinExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            BTCAddress myAddress = new BTCAddress();
            Key pk = myAddress.GetPrivateKey();
            Console.WriteLine(myAddress.GetMainAddressFromPublicKey(pk));
        }
    }
}
