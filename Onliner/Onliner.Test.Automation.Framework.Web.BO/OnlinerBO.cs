using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

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