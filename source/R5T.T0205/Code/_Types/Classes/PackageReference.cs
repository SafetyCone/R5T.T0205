using System;

using R5T.T0142;


namespace R5T.T0205
{
    /// <inheritdoc cref="IPackageReference"/>
    [DataTypeMarker]
    public class PackageReference : IPackageReference
    {
        public IPackageName Name { get; set; }
        public IPackageVersion Version { get; set; }
    }
}
