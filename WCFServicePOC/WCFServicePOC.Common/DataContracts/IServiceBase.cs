using System.ServiceModel;

namespace WCFServicePOC.Common.DataContracts
{
    [ServiceContract]
    public interface IServiceBase
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }
}