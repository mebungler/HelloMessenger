using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloMessanger.Core
{
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// Indicates whether login is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// No one gives a ...
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Message to show the user
        /// </summary>
        public string ErrorMessage { set; get; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        public ICommand GoToRegisterPageCommand { get; set; } 

        public ICommand GoToLoginPageCommand { get; set; }

        

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(async () => await Login());
            GoToRegisterPageCommand = new RelayCommand(async() => {await GoToRegisterPage(); });
            GoToLoginPageCommand = new RelayCommand(async() => {await GoToLoginPage(); });
        }

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task Login()
        {
            //Spin up
            LoginIsRunning = true;
            //Login :)
            await Task.Delay(1000);
            //var par = parameter as SecureString;
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat);

        }

        private async Task GoToRegisterPage()
        {
            await Task.Delay(1);
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Register; 
        }

        private async Task GoToLoginPage()
        {
            await Task.Delay(1);
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Login;
        }


        #endregion

        #region Helpers
        private void SetBasicAuthHeader(WebRequest req, string userName, string userPassword)
        {
            string authInfo = userName + ":" + userPassword;
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            req.Headers["Authorization"] = "Basic " + authInfo;
            req.PreAuthenticate = true;
        }
        #endregion
    }
}
