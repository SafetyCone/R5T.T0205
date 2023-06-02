using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0205
{
    /// <inheritdoc cref="IPackageName"/>
    [StrongTypeImplementationMarker]
    public class PackageName : TypedBase<string>, IStrongTypeMarker,
        IPackageName
    {
        public PackageName(string value)
            : base(value)
        {
        }
    }
}