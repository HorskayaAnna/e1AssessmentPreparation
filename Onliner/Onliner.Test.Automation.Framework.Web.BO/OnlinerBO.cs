using System;

namespace Onliner.Test.Automation.Framework.Web.BO
{
    public class OnlinerBO
    {
        public static T Page<T>() 
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}