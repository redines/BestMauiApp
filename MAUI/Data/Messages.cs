using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MAUI.Data
{
    public class RefreshMessage : ValueChangedMessage<bool>
    {
        public RefreshMessage(bool value) : base(value)
        {
        }
    }
}
