using System;
using System.Security;
using HelloMessanger.Core;

namespace HelloMessanger
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHaveParameter
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
