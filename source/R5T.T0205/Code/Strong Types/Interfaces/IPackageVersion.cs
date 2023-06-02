using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0205
{
    /// <summary>
    /// Strongly-types a version as a package version.
    /// Useful for specifying the version of a package in .NET project files.
    /// </summary>
    [StrongTypeMarker]
    public interface IPackageVersion : IStrongTypeMarker,
        ITyped<Version>
    {
    }
}