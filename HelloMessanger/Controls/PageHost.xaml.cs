using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace HelloMessanger
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependency property



        public BasePage CurrentPage
        {
            get { return (BasePage)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChanged));


        /// <summary>
        /// Changed when <see cref="CurrentPage"/> changed
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        public static void CurrentPagePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //Get frames
            var newPageFrame = (sender as PageHost).NewFrame;
            var oldPageFrame = (sender as PageHost).OldFrame;
            //Save old page content
            var oldPageContent = newPageFrame.Content;
            //Clear frame content of new page
            newPageFrame.Content = null;
            //Update the frame content
            oldPageFrame.Content = oldPageContent;
            //Access to old page 
            var oldPage = oldPageContent as BasePage;
            if (oldPage != null)
            {
                //Animate out previous page
                oldPage.ShouldAnimateOut = true;
            }
            //Set new value
            newPageFrame.Content = e.NewValue;
        }

        #endregion

        #region Default constructor
        public PageHost()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
