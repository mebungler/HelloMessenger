using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HelloMessanger.Core
{
    /// <summary>
    /// An interface for class to provide secure password
    /// </summary>
    public interface IHaveParameter
    {
        /// <summary>
        /// The secure password
        /// </summary>
        SecureString SecurePassword { get; }
    }
}
