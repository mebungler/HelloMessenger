
using System.Windows;
using System.Windows.Controls;

namespace HelloMessanger
{
    /// <summary>
    /// Property that assigns keyboard focus to this element
    /// </summary>
    public class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var control = sender as Control;
            //Check the value
            if (control == null)
                return;
            control.Loaded += (s, se) => { control.Focus(); };
        }
    }
}
