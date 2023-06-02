using System;

using R5T.T0142;


namespace R5T.T0205
{
    /// <summary>
    /// Represents a package reference.
    /// Useful for .NET project files.
    /// </summary>
    [DataTypeMarker]
    public interface IPackageReference
    {
        IPackageName Name { get; set; }
        IPackageVersion Version { get; set; }
    }
}
