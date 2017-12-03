using System.Security.Cryptography.X509Certificates;

using NBitcoin;

namespace MyBitcoinExperiments
{
    public class BTCAddress
    {
        public BitcoinAddress GetMainAddressFromPublicKey(Key privateKey)
        {
            PubKey publicKey = privateKey.PubKey;
            return publicKey.GetAddress(Network.Main);
        }

        public Key GetPrivateKey()
        {
            Key privateKey = new Key();
            return privateKey;
        }
    }
}