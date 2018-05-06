
using System.Collections.Generic;

namespace HelloMessanger.Core
{
    /// <summary>
    /// Design time data for <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A singleton instance of design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Concstuctor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome, I bet it will be fast too!",
                    ProfilePictureRGB = "30995c",
                    NewMessageAvailable=true,
                },
                new ChatListItemViewModel
                {
                    Initials = "BU",
                    Name = "Bungler",
                    Message = "Thanks bro!",
                    ProfilePictureRGB = "7ae6c9",
                },
                new ChatListItemViewModel
                {
                    Initials = "AS",
                    Name = "Akmal Salikhov",
                    Message = "Great keep it up!!!",
                    ProfilePictureRGB = "ff9832",
                    IsSelected=true
                },
                new ChatListItemViewModel
                {
                    Initials = "SH",
                    Name = "Shokhjahon",
                    Message = "What is the Bitcoin?/$",
                    ProfilePictureRGB = "34cf9c",
                },
               new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome, I bet it will be fast too!",
                    ProfilePictureRGB = "30995c",
                },
                new ChatListItemViewModel
                {
                    Initials = "BU",
                    Message = "Thanks bro!",
                    Name = "Bungler",
                    ProfilePictureRGB = "7ae6c9",
                },
                new ChatListItemViewModel
                {
                    Initials = "AS",
                    Name = "Akmal Salikhov",
                    Message = "Great keep it up!!!",
                    ProfilePictureRGB = "ff9832",
                },
                new ChatListItemViewModel
                {
                    Initials = "SH",
                    Name = "Shokhjahon",
                    Message = "What is the Bitcoin?/$",
                    ProfilePictureRGB = "34cf9c",
                },
            };

        }

        #endregion
    }
}
