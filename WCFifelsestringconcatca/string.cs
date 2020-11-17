using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{
   
    {
        public void DoWork()
        {
        }
        public string Concat(string a, string b)
        {
            return a + b;
        }
    }
}