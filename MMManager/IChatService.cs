
using System.ServiceModel;
using MMManager.GameObjects;
namespace MMManager
{
    [ServiceContract( CallbackContract = typeof(IChatService), Namespace ="MMManager")]
    public interface IChatService
    {
        [OperationContract(IsOneWay = true)]
        void Join(string memberName);
        [OperationContract(IsOneWay = true)]
        void Leave(string memberName);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string memberName, string message);

        [OperationContract(IsOneWay = true)]
        void InitializeMesh();

        [OperationContract(IsOneWay = true)]
        void TicTacToeMessage(string memberName, TicTacToeBoard generatedBoard);
    }
}
