
namespace HelloMessanger.Core
{
    public class ChatListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The name of the sender in <see cref="ChatListItem"/>
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// The message of the sender in <see cref="ChatListItem"/>
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// The initials of the picture in <see cref="ChatListItem"/>
        /// </summary>
        public string Initials { set; get; }

        /// <summary>
        /// The color of the sender's picture in <see cref="ChatListItem"/>
        /// </summary>
        public string ProfilePictureRGB { set; get; }

        /// <summary>
        /// Flag to indicate that there is new message
        /// </summary>
        public bool NewMessageAvailable { set; get; }

        /// <summary>
        /// Flag to indicate whether item is selected or not
        /// </summary>
        public bool IsSelected { set; get; }

    }
}
