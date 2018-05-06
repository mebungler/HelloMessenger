
namespace HelloMessanger.Core
{
    /// <summary>
    /// Design time data for <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A singleton instance of design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();

        #endregion

        #region Constuctor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "BU";
            ProfilePictureRGB = "321cfe";
            Name = "Bungler";
            Message = "Why trimming is not working. If it overflows vertically there should not be a ScrollBar";
        }

        #endregion
    }
}
