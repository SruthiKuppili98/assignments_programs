using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Createservice
{
    
    [ServiceContract]
    public interface ICalculation
    {
        
        [OperationContract]
        int sum(int num1, int num2);

        [OperationContract]
        int Subtract(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        int Divison(int num1, int num2);
    }
}

[DataContract] 
public class CompositeType
{
    bool boolvalue = true; 
    String stringvalue = "Hello World";
    [DataMember]
    public bool BoolValue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }
    [DataMember]
    public String StringlValue
    {
        get { return stringvalue; }
        set { stringvalue = value; }
    }
}