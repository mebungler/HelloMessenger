
using System.Collections.Generic;

namespace HelloMessanger.Core
{
    public class ChatListViewModel : BaseViewModel
    {
        /// <summary>
        /// Chat list items for the chat list
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set;  }
    }
}
