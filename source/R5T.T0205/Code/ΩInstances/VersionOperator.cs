using System;


namespace R5T.T0205
{
    public class VersionOperator : IVersionOperator
    {
        #region Infrastructure

        public static IVersionOperator Instance { get; } = new VersionOperator();


        private VersionOperator()
        {
        }

        #endregion
    }
}
