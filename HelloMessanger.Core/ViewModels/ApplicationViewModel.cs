using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMessanger.Core
{
    public class ApplicationViewModel:BaseViewModel
    {

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { set; get; } = ApplicationPage.Login;

        /// <summary>
        /// Flag to indicate whether Side menu is show or not
        /// </summary>
        public bool SideMenuVisible { set; get; } 

        internal void GoToPage(ApplicationPage page)
        {
            //Set the page
            CurrentPage = page;
            //Show the menu
            SideMenuVisible = page == ApplicationPage.Chat;
        }
    }
}
