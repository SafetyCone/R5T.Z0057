using System;


namespace R5T.Z0057.Platform
{
    public class TargetFrameworkMonikers : ITargetFrameworkMonikers
    {
        #region Infrastructure

        public static ITargetFrameworkMonikers Instance { get; } = new TargetFrameworkMonikers();


        private TargetFrameworkMonikers()
        {
        }

        #endregion
    }
}
