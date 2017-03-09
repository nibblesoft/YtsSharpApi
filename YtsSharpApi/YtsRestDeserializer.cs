using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace YtsSharpApi
{
    class YtsRestDeserializer : IDeserializer
    {
        public string RootElement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Namespace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DateFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T Deserialize<T>(IRestResponse response)
        {
            throw new NotImplementedException();
        }
    }
}
