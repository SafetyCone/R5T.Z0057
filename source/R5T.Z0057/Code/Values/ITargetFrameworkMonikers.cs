using System;

using R5T.T0131;
using R5T.T0218;
using R5T.T0218.Extensions;


namespace R5T.Z0057
{
    /// <inheritdoc cref="Platform.ITargetFrameworkMonikers"/>
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.ITargetFrameworkMonikers _Platform => Platform.TargetFrameworkMonikers.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><inheritdoc cref="NET_8" path="/summary"/></para>
        /// When you need a target framework moniker, but don't want to think about it.
        /// Chooses <see cref="NET_8"/> as the default.
        /// </summary>
        public ITargetFrameworkMoniker Default => this.NET_8;

        /// <summary>
        /// When you want to use the standard target framework moniker.
        /// Chooses <see cref="NET_6"/> as the standard.
        /// </summary>
        public ITargetFrameworkMoniker Standard => this.NET_6;


        /// <inheritdoc cref="Platform.ITargetFrameworkMonikers.NET_8"/>
        public ITargetFrameworkMoniker NET_8 => _Platform.NET_8.ToTargetFrameworkMoniker();

        /// <inheritdoc cref="Platform.ITargetFrameworkMonikers.NET_7"/>
        public ITargetFrameworkMoniker NET_7 => _Platform.NET_7.ToTargetFrameworkMoniker();

        /// <inheritdoc cref="Platform.ITargetFrameworkMonikers.NET_6"/>
        public ITargetFrameworkMoniker NET_6 => _Platform.NET_6.ToTargetFrameworkMoniker();

        public ITargetFrameworkMoniker NET_6_Windows => "net6.0-windows".ToTargetFrameworkMoniker();

        public ITargetFrameworkMoniker NET_5 => _Platform.NET_5.ToTargetFrameworkMoniker();

        /// <summary>
        /// Useful if you want to allow old .NET Framework (4.6.2 and higher) support.
        /// </summary>
        public ITargetFrameworkMoniker NET_Standard2_0 => "netstandard2.0".ToTargetFrameworkMoniker();

        /// <inheritdoc cref="Platform.ITargetFrameworkMonikers.Net_Standard2_1"/>
        public ITargetFrameworkMoniker NET_Standard2_1 => _Platform.Net_Standard2_1.ToTargetFrameworkMoniker();

        public ITargetFrameworkMoniker NET_Core3_1 => "netcoreapp3.1".ToTargetFrameworkMoniker();

        public ITargetFrameworkMoniker NET_Framework4_8 => "net48".ToTargetFrameworkMoniker();
    }
}
