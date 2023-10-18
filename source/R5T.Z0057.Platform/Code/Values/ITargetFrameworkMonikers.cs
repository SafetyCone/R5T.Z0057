using System;

using R5T.T0131;


namespace R5T.Z0057.Platform
{
    /// <summary>
	/// See: <see href="https://learn.microsoft.com/en-us/dotnet/standard/frameworks"/>
	/// And for what .NET Standard versions support what frameworks: https://learn.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0#select-net-standard-version
	/// </summary>
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers : IValuesMarker
    {
        /// <summary>
        /// <para>"netcoreapp2.2"</para>
        /// .NET Core 2.2 application.
        /// </summary>
        public const string NET_App_2_2_Constant = "netcoreapp2.2";

        /// <inheritdoc cref="NET_App_2_2_Constant"/>
        public string NET_App_2_2 => ITargetFrameworkMonikers.NET_App_2_2_Constant;

        /// <summary>
        /// <para>"net6.0"</para>
        /// .NET 6.0.
        /// </summary>
        public const string NET_6_Constant = "net6.0";

        /// <inheritdoc cref="NET_6_Constant"/>
        public string NET_6 => ITargetFrameworkMonikers.NET_6_Constant;

        /// <summary>
        /// <para>"net5.0"</para>
        /// .NET 5.0
        /// </summary>
        public const string NET_5_Constant = "net5.0";

        /// <inheritdoc cref="NET_5_Constant"/>
        public string NET_5 => ITargetFrameworkMonikers.NET_5_Constant;

        /// <summary>
        /// <para>"netstandard2.0"</para>
        /// </summary>
        public const string Net_Standard2_0_Constant = "netstandard2.0";

        /// <inheritdoc cref="Net_Standard2_0_Constant"/>
        public string Net_Standard2_0 => ITargetFrameworkMonikers.Net_Standard2_0_Constant;

        /// <summary>
        /// <para>"netstandard2.1"</para>
        /// </summary>
        /// <remarks>
        /// Note: as of this version of .NET Standard, the old .NET framework is no longer supported.
        /// </remarks>
        public const string Net_Standard2_1_Constant = "netstandard2.1";

        /// <inheritdoc cref="Net_Standard2_1_Constant"/>
        public string Net_Standard2_1 => ITargetFrameworkMonikers.Net_Standard2_1_Constant;
    }
}
