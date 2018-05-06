using HelloMessanger.Core;
using System.Windows;
using System.Windows.Input;

namespace HelloMessanger
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members
        /// <summary>
        /// Flag for <see cref="CurrentPage"/>
        /// </summary>
        private ApplicationPage mCurrentPage { get; set; }

        /// <summary>
        /// The window ViewModel controls
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// Margin around the window to allow dropshadow
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// Window radius
        /// </summary>
        private int mWindowRadious = 10;

        #endregion

        #region Public Properties

        public static WindowViewModel Instance;

        /// <summary>
        /// Smallest heigjht
        /// </summary>
        public double WindowMinimumHeight { get; set; }

        /// <summary>
        /// Smallest heigjht
        /// </summary>
        public double WindowMinimumWidth { get; set; }


        /// <summary>
        /// The size of the Resize border
        /// </summary>
        public int ResizeBorder { get { return Borderless ? 0 : 6; } set { } }

        /// <summary>
        /// Thickness of resize border
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// Inner padding of main content
        /// </summary>
        public int MainWindowInnerPadding { get; set; }

        /// <summary>
        /// Inner padding of main content
        /// </summary>
        public Thickness MainContentInnerPaddingThickness { get { return new Thickness(MainWindowInnerPadding); } }

        /// <summary>
        /// Margin around window to allow dropshadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set { OuterMarginSize = value; }
        }

        /// <summary>
        /// Margin around window to allow dropshadow
        /// </summary>
        public Thickness OuterMarginThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// The radius of the edges
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadious;
            }
            set { WindowRadius = value; }
        }

        /// <summary>
        /// Corner radius of the edges
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// Height of the region that can drag the form
        /// </summary>
        public int TitleHeight { set; get; }

        /// <summary>
        /// Title height grid length of Title
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        /// <summary>
        /// Represents that if the window maximized it should be borderless
        /// </summary>
        public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized); } set { } }

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get { return mCurrentPage; } set { mCurrentPage = value; OnPropertyChanged("CurrentPage"); } }

        #endregion

        #region Commands

        public ICommand MinimizeCommand { get; set; }

        public ICommand MaximizeCommand { get; set; }

        public ICommand CloseCommand { get; set; }

        public ICommand MenuCommand { get; set; }


        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(("ResizeBorder"));
                OnPropertyChanged(("ResizeBorderThickness"));
                OnPropertyChanged(("OuterMarginSize"));
                OnPropertyChanged(("OuterMarginThickness"));
                OnPropertyChanged(("WindowRadius"));
                OnPropertyChanged(("WindowCornerRadius"));

            };
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            WindowMinimumWidth = 800;
            TitleHeight = 42;
            MainWindowInnerPadding = 0;
            WindowMinimumHeight = 400;
            Instance = this;
            CurrentPage = ApplicationPage.Login;
        }
        #endregion

        #region Helpers

        /// <summary>
        /// Gets the current position of mouse
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            var positions = Mouse.GetPosition(mWindow);
            return new Point(positions.X + mWindow.Left, positions.Y + mWindow.Top);
        }

        #endregion

    }
}
