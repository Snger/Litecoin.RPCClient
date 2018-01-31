using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timemicro.Litecoin.RPCClient.Methods;

namespace Timemicro.Litecoin.RPCClient.MSUnitTests
{
    [TestClass]
    public class GetWalletInfoTest
    {
        static JsonRPCClient RPC = new JsonRPCClient("http://127.0.0.1:19332", "litecoinrpc", "123456", "");

        [TestMethod]
        public void TestGetWalletInfo()
        {
            var resp = RPC.Call<GetWalletInfoResponse>(JsonRPCMethods.GetWalletInfo, new GetWalletInfoParams());

            Console.WriteLine(resp);
        }
    }
}
