using System;

using R5T.T0132;


namespace R5T.T0205
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IPackageName ToPackageName(string value)
        {
            var output = new PackageName(value);
            return output;
        }

        public IPackageVersion ToPackageVersion(string value)
        {
            var version = Instances.VersionOperator_F0000.ToVersion(value);

            var output = new PackageVersion(version);
            return output;
        }
    }
}
