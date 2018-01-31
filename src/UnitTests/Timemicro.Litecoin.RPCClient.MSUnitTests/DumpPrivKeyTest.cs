using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timemicro.Litecoin.RPCClient.Methods;

namespace Timemicro.Litecoin.RPCClient.MSUnitTests
{
    [TestClass]
    public class DumpPrivKeyTest
    {
        static JsonRPCClient RPC = new JsonRPCClient("http://127.0.0.1:19332", "litecoinrpc", "123456", "");

        [TestMethod]
        public void TestDumpPrivKey()
        {
            var resp1 = RPC.Call<GetNewAddressResponse>(JsonRPCMethods.GetNewAddress, new GetNewAddressParams());
            Console.WriteLine("GetNewAddress:");
            Console.WriteLine(resp1);

            var resp2 = RPC.Call<WalletPassphraseResponse>(JsonRPCMethods.WalletPassphrase, new WalletPassphraseParams()
            {
                Passphrase = "fslong25!@#",
                Seconds = 30
            });
            Console.WriteLine("WalletPassphrase:");
            Console.WriteLine(resp2);

            var resp3 = RPC.Call<DumpPrivKeyResponse>(JsonRPCMethods.DumpPrivKey, new DumpPrivKeyParams()
            {
                P2PKHAddress = resp1.Result
            });

            Console.WriteLine("DumpPrivKey:");
            Console.WriteLine(resp3);
        }
    }
}
