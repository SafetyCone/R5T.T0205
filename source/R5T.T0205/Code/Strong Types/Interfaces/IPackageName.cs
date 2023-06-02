using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0205
{
    /// <summary>
    /// Strongly-types a string as the name of a package.
    /// Useful for specifying the name of NuGet packages of .NET project files.
    /// </summary>
    [StrongTypeMarker]
    public interface IPackageName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}