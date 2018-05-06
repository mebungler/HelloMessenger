using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HelloMessanger.Core
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {

        public BaseViewModel()
        {
        }

        /// <summary>
        /// The event which is called when any item changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this ti fire <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        /// <summary>
        /// Runs a command if the flag is not set
        /// If the flag is true(indicating that the function is runnging) the action is not run
        /// If the flag is false (indicating that function is not run) the action is run
        /// Once the function terminated reset the flag to false
        /// </summary>
        /// <param name="updatingFlag">The boolean property flag defining if the command is already running</param>
        /// <param name="action">The action to run if the action is not runnung yet</param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Check if the flag property is true(meaning action is already running
            if (updatingFlag.GetPropertyValue())
                return;
            // Set updating flag to true (meaning that we are running the action)
            updatingFlag.SetPropertyValue(true);
        }


    }
}
