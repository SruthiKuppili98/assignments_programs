using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{

    [ServiceContract]
    public interface IStringconcat
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string Concat(string a, string b);
    }
}
