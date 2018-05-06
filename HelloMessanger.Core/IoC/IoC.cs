using Ninject;

namespace HelloMessanger.Core
{
    /// <summary>
    /// Inversion of Control container for out IoC
    /// </summary>
    public static class IoC
    {
        #region Public properties

        /// <summary>
        /// The Kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { private set; get; } = new StandardKernel();

        #endregion

        #region Construction

        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready use
        /// NOTE:Must be called as soon as the application loadss
        /// </summary>
        public static void Setup()
        {
            // Bind all required ViewModels
            BindViewModels();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            // Bind single Instance of ApplicationViewModel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        } 
        #endregion

        #region HelperMethods
        /// <summary>
        /// Gets a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        #endregion
    }
}
