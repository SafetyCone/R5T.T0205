using System;


namespace R5T.T0205.Extensions
{
    public static class VersionExtensions
    {
        public static IPackageVersion ToPackageVersion(this Version version)
        {
            return Instances.VersionOperator.ToPackageVersion(version);
        }
    }
}
