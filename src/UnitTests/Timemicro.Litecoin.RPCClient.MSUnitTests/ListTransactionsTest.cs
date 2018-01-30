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
    public class ListTransactionsTest
    {
        static JsonRPCClient RPC = new JsonRPCClient("http://127.0.0.1:19332", "litecoinrpc", "123456");

        [TestMethod]
        public void TestListTransactions()
        {
            var resp = RPC.Call<ListTransactionsResponse>(JsonRPCMethods.ListTransactions, new ListTransactionsParams()
            {
                TakeCount = 2,
                Skip = 0
            });

            Console.WriteLine(resp);

            var resp1 = RPC.Call<ListTransactionsResponse>(JsonRPCMethods.ListTransactions, new ListTransactionsParams()
            {
                TakeCount = 2,
                Skip = 2
            });

            Console.WriteLine(resp1);
        }
    }
}
