using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HelloMessanger
{
    public static class PageAnimations
    {
        /// <summary>
        /// Binds animation to the page and can be accessed by any instance of the bage or any class that is inhereted from page!!!
        /// </summary>
        /// <param name="page">The page that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            var sb = new Storyboard();
            sb.AddSlideFromRight(seconds, page.WindowWidth-6);
            sb.AddFadeIn(seconds);
            sb.Begin(page);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Binds animation to the page and can be accessed by any instance of the page or any class that is inhereted from page!!!
        /// </summary>
        /// <param name="page">The page that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            var sb = new Storyboard();
            sb.AddSlideToLeft(seconds, page.WindowWidth-10);
            sb.AddFadeOut(seconds);
            sb.Begin(page);
            await Task.Delay((int)(seconds * 1000));
            page.Visibility = Visibility.Collapsed;
        }


    }
}
