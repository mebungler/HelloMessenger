using HelloMessanger.Core;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HelloMessanger
{

    /// <summary>
    /// Non generic class to disable errors and to be able to access in dependency property
    /// </summary>
    public class BasePage : Page
    {
        #region Public properties
        /// <summary>
        /// The animation when page is loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; }

        /// <summary>
        /// The animation when page is unloaded
        /// </summary>
        public PageAnimation PageUnLoadAnimation { get; set; }

        /// <summary>
        /// Duration of the animation
        /// </summary>
        public float SlideSeconds { get; set; }

        /// <summary>
        /// The flag that indicates whether to load the page
        /// </summary>
        public bool ShouldAnimateOut { set; get; }

        #endregion

        #region Constructor
        public BasePage()
        {
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;
            this.Loaded += BasePage_Loaded;

            SlideSeconds = 0.5f;
            PageLoadAnimation = PageAnimation.SlideInAndFadeInFromRight;
            PageUnLoadAnimation = PageAnimation.SlideOffAndFadeOutToLeft;
        }
        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// Animate in when page is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            //Animate when it is required
            if (ShouldAnimateOut)
                //Animate out
                await AnimateOut();
            //Otherwise
            else
                //Animate in
                await AnimateIn();
        }

        /// <summary>
        /// Animates in this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            if (this.PageLoadAnimation == PageAnimation.None)
                return;
            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideInAndFadeInFromRight:
                    await this.SlideAndFadeInFromRight(SlideSeconds);
                    break;
            }
        }

        /// <summary>
        /// Animates in this page
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            if (this.PageUnLoadAnimation == PageAnimation.None)
                return;
            switch (this.PageUnLoadAnimation)
            {
                case PageAnimation.SlideOffAndFadeOutToLeft:
                    await this.SlideAndFadeOutToLeft(SlideSeconds);
                    break;
            }
        }
        #endregion
    }
    /// <summary>
    /// Base page that other page inheret from
    /// </summary>
    /// <typeparam name="VM"></typeparam>
    public abstract class BasePage<VM> : BasePage
        where VM : BaseViewModel, new()
    {

        #region Private Members

        /// <summary>
        /// ViewModel of the page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The view model assosiated with this page
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                if (mViewModel == value)
                    return;
                mViewModel = value;
                this.DataContext = mViewModel;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            this.ViewModel = new VM();
        }

        #endregion

    }
}
