namespace HelloMessanger
{
    /// <summary>
    /// Styles for appearing / dissappearing of the page
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// Used when page has no animation
        /// </summary>
        None=0,
        /// <summary>
        /// Used when page loaded
        /// </summary>
        SlideInAndFadeInFromRight=1,
        /// <summary>
        /// Used when page closed / exited
        /// </summary>
        SlideOffAndFadeOutToLeft=2
    }
}
