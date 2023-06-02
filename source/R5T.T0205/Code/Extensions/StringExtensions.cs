using System;


namespace R5T.T0205.Extensions
{
    public static class StringExtensions
    {
        public static IPackageName ToPackageName(this string value)
        {
            return Instances.StringOperator.ToPackageName(value);
        }

        public static IPackageVersion ToPackageVersion(this string value)
        {
            return Instances.StringOperator.ToPackageVersion(value);
        }
    }
}
