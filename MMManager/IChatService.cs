﻿
using System.ServiceModel;
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

        //[OperationContract(IsOneWay = true)]
        //void SendButton(string memberName, int ButtonNum);
        //[OperationContract(IsOneWay = true)]
        //void RequestStartTicTacToe(string memberName, TicTacToeBoard generatedBoard);
        [OperationContract(IsOneWay = true)]
        void TicTacToeMessage(string memberName, TicTacToeBoard generatedBoard);
    }
}