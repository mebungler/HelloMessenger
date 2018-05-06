using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace HelloMessanger
{
    /// <summary>
    /// Helper class for <see cref="Storyboard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// Method to add slide animation to the story board itself can be accessed by any instance of storyboard class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        /// <param name="offset">Distance from the right to start from</param>
        /// <param name="decelerationRatio">Deceleration ratio</param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin?offset:0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Method to add slide animation to the story board itself can be accessed by any instance of storyboard class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        /// <param name="offset">Distance from the left to start from</param>
        /// <param name="decelerationRatio">Deceleration ratio</param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Method to add slide animation to the story board itself can be accessed by any instance of storyboard class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        /// <param name="offset">Distance from the right to end to</param>
        /// <param name="decelerationRatio">Deceleration ratio</param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Method to add slide animation to the story board itself can be accessed by any instance of storyboard class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        /// <param name="offset">Distance from the left to end to</param>
        /// <param name="decelerationRatio">Deceleration ratio</param>
        /// <param name="keepMargin">Flag to indicate whether to keep the margin or not</param> 
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Method to add fade animation to the story board itself can be accessed by any instance of <see cref="Storyboard"/> class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Method to add fade animation to the story board itself can be accessed by any instance of <see cref="Storyboard"/> class (Great!!!)
        /// </summary>
        /// <param name="storyboard">Storyboard to add animation</param>
        /// <param name="seconds">Duration of storyboard</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);
        }
    }
}
