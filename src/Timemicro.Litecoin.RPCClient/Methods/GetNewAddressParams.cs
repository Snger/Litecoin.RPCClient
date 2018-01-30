﻿using System;
namespace Timemicro.Litecoin.RPCClient.Methods
{
    public class GetNewAddressParams : JsonRPCRequestParams
    {
        public GetNewAddressParams()
        {
        }

        public string Account
        {
            get { return Get<string>(0); }
            set { Set(0, value);}
        }
    }
}
