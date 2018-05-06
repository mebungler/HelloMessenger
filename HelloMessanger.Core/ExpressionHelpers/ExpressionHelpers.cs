using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelloMessanger
{
    /// <summary>
    /// Helper for the <see cref="Expression"/>
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles the <see cref="Expression"/> and returns the invoked value
        /// </summary>
        /// <typeparam name="T">Type if the fucntion output</typeparam>
        /// <param name="lambda">Expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda) { return lambda.Compile().Invoke(); }

        /// <summary>
        /// Sets the underlying properties value to given value
        /// </summary>
        /// <typeparam name="T">Type of property</typeparam>
        /// <param name="lambda">Expression to set</param>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            // Converts lambda () => some.Property to some.Property
            var expression = (lambda as LambdaExpression).Body as MemberExpression;

            // Get the property so that we can set it
            var propertyInfo = (PropertyInfo)expression.Member;
            // Find the class the property in
            var target = lambda.Compile().DynamicInvoke();
            // Set the value
            propertyInfo.SetValue(target, value);
        }
    }
}
