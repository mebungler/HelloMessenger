
using HelloMessanger.Core;

namespace HelloMessanger
{
    public class ViewModelLocator
    {
        public static ViewModelLocator Instance { private set; get; } = new ViewModelLocator();
        public static ApplicationViewModel ApplicationViewModel => IoC.Get<ApplicationViewModel>();
    }
}
