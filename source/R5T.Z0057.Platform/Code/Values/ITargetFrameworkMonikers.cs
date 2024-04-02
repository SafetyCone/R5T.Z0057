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
        /// <para>"net5.0"</para>
        /// .NET 5.0
        /// </summary>
        public const string NET_5_Constant = "net5.0";

        /// <inheritdoc cref="NET_5_Constant"/>
        public string NET_5 => ITargetFrameworkMonikers.NET_5_Constant;

        /// <summary>
        /// <para>"net6.0"</para>
        /// .NET 6.0.
        /// </summary>
        public const string NET_6_Constant = "net6.0";

        /// <inheritdoc cref="NET_6_Constant"/>
        public string NET_6 => ITargetFrameworkMonikers.NET_6_Constant;

        /// <summary>
        /// <para>"net7.0"</para>
        /// .NET 7.0.
        /// </summary>
        public const string NET_7_Constant = "net7.0";

        /// <inheritdoc cref="NET_7_Constant"/>
        public string NET_7 => ITargetFrameworkMonikers.NET_7_Constant;

        /// <summary>
        /// <para>"net8.0"</para>
        /// .NET 8.0.
        /// </summary>
        public const string NET_8_Constant = "net8.0";

        /// <inheritdoc cref="NET_8_Constant"/>
        public string NET_8 => ITargetFrameworkMonikers.NET_8_Constant;

        /// <summary>
        /// <para>"net8.0-windows"</para>
        /// .NET 8.0 for Windows Forms.
        /// </summary>
        public const string NET_8_Windows_Constant = "net8.0-windows";

        /// <inheritdoc cref="NET_8_Windows_Constant"/>
        public string NET_8_Windows => ITargetFrameworkMonikers.NET_8_Windows_Constant;

        /// <summary>
        /// <para>"netcoreapp2.2"</para>
        /// .NET Core 2.2 application.
        /// </summary>
        public const string NET_App_2_2_Constant = "netcoreapp2.2";

        /// <inheritdoc cref="NET_App_2_2_Constant"/>
        public string NET_App_2_2 => ITargetFrameworkMonikers.NET_App_2_2_Constant;

        /// <summary>
        /// <para>"netcoreapp3.1"</para>
        /// .NET Core 3.1 application.
        /// </summary>
        public const string NET_App_3_1_Constant = "netcoreapp3.1";

        /// <inheritdoc cref="NET_App_3_1_Constant"/>
        public string NET_App_3_1 => ITargetFrameworkMonikers.NET_App_3_1_Constant;

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
        /// Note: as of this version of .NET Standard, the original Windows-only .NET framework is no longer supported.
        /// </remarks>
        public const string Net_Standard2_1_Constant = "netstandard2.1";

        /// <inheritdoc cref="Net_Standard2_1_Constant"/>
        public string Net_Standard2_1 => ITargetFrameworkMonikers.Net_Standard2_1_Constant;
    }
}
