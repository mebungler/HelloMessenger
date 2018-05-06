using System.Windows;

namespace HelloMessanger
{
    /// <summary>
    /// Base class to run any animation when the boolean is set to true 
    /// and reverse when it set to false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimationBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
        where Parent : BaseAttachedProperty<Parent, bool>, new()
    {

        #region Public Properties

        public bool FirstLoad { get; set; }

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object e)
        {
            // Get the framework element
            var element = sender as FrameworkElement;
            if (element == null)
                return;

            // Dont fire if the value is not changed
            if (sender.GetValue(ValueProperty) == e && !FirstLoad)
                return;

            // When it is first load
            if (FirstLoad)
            {
                // Create single self-unhookable event
                // for the elements Loaded event
                RoutedEventHandler onLoaded = null;
                onLoaded = (ss, ee) =>
                 {
                     //Unhook ourselves
                     element.Loaded -= onLoaded;

                     // Do desired animation
                     DoAnimation(element, (bool)e);

                     // We are loaded first
                     FirstLoad = false;
                 };
                // Hook into the event when Loaded
                element.Loaded += onLoaded;
            }
            else
            {
                // Do desired animation
                DoAnimation(element, (bool)e);
            }
        }

        /// <summary>
        /// The anumation Function that is firedd when value changed
        /// </summary>
        /// <param name="element">Element to animate</param>
        /// <param name="value">Flag indicating whether loaded or unloaded</param>
        protected virtual void DoAnimation(FrameworkElement element, bool value) { }
    }

    /// <summary>
    /// Animates a framework element sliding it in  from the left on show
    /// and sliding out to left on hide
    /// </summary>
    public class AnimateSlideInFromLeftProperty : AnimationBaseProperty<AnimateSlideInFromLeftProperty>
    {
        protected override async void DoAnimation(FrameworkElement element, bool value)
        {
            if (value)
            {
                //Animate in
                await element.SlideAndFadeInFromRight(FirstLoad ? 0f : 0.3f,false);
            }
            else
            {
                //Animate out
                await element.SlideAndFadeOutToLeft(FirstLoad ? 0f : 0.3f,false);
            }
        }
    }
}
