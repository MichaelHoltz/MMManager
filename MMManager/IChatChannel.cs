using System.ServiceModel;
namespace MMManager
{
    #region Chat Channel Interface
    //this channel interface provides a multiple inheritence adapter for our channel factory
    //that aggregates the two interfaces need to create the channel
    public interface IChatChannel : IChatService, IClientChannel
    {
    }
    #endregion
}
