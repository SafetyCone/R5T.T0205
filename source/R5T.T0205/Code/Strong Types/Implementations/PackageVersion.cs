using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0205
{
    /// <inheritdoc cref="IPackageVersion"/>
    [StrongTypeImplementationMarker]
    public class PackageVersion : TypedBase<Version>, IStrongTypeMarker,
        IPackageVersion
    {
        public PackageVersion(Version value)
            : base(value)
        {
        }
    }
}