using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace HelloMessanger
{
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The element that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideFromRight(seconds, element.ActualWidth-6, keepMargin: keepMargin);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The page that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideToLeft(seconds, element.ActualWidth, keepMargin: keepMargin);
            sb.AddFadeOut(seconds);
            sb.Begin(element);
            await Task.Delay((int)(seconds * 1000));
            element.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Framework element animations
        /// </summary>
        /// <param name="element">The element that needs to be animated</param>
        /// <param name="seconds">Duration of the animation </param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            var sb = new Storyboard();
            sb.AddSlideFromLeft(seconds, element.ActualWidth - 6,keepMargin:keepMargin);
            sb.AddFadeIn(seconds);
            sb.Begin(element);
            element.Visibility = Visibility.Visible;
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
