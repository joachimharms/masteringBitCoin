using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_Keys_F_AdvancedKeysAndAddresses
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Versuche das auch mit NBitcoin hinzubekommen: (Seite 81):
            // Test the encrypted keys in Table 4-5 using bitaddress.org to see how you can get the
            // decrypted key by entering the passphrase.

            // Table 4-5. Example of BIP-38 encrypted private key
            //             Private Key(WIF) 5J3mBbAH58CpQ3Y5RNJpUKPE62SQ5tfcvU2JpbnkeyhfsYB1Jcn
            //              Passphrase MyTestPassphrase
            //             Encrypted Key(BIP - 38) 6PRTHL6mWa48xSopbU1cKrVjpKbBZxcLRRCdctLJ3z5yxE87MobKoXdTsJ


            // Seite 82 folgenden Python Code mit NBitcoin reproduzieren:
            // $ echo dup hash160 [ 89abcdefabbaabbaabbaabbaabbaabbaabbaabba ] equalverify
            //checksig > script
            //    $ bx script-encode < script | bx sha256 | bx ripemd160 | bx base58check - encode
            //    --version 5
            //3F6i6kwkevjR7AsAd4te2YB2zZyASEm1HM
        }
    }
}
