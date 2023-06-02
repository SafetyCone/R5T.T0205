using System;


namespace R5T.T0205
{
    public static class Instances
    {
        public static IStringOperator StringOperator => T0205.StringOperator.Instance;
        public static IVersionOperator VersionOperator => T0205.VersionOperator.Instance;
        public static F0000.IVersionOperator VersionOperator_F0000 => F0000.VersionOperator.Instance;
    }
}