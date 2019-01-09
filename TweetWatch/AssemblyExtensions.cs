using System;
using System.Reflection;

namespace TweetWatch
{
    internal static class AssemblyExtensions
    {
        public static string Version(this Assembly assembly)
        {
            Version version = assembly.GetName().Version;
            return $"Version {version.Major}.{version.Minor}.{version.Build}";
        }

        public static string Copyright(this Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }
    }
}
