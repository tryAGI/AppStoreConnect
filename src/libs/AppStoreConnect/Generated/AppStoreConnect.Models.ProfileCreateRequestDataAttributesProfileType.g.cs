
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileCreateRequestDataAttributesProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        IosAppAdhoc,
        /// <summary>
        /// 
        /// </summary>
        IosAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        IosAppInhouse,
        /// <summary>
        /// 
        /// </summary>
        IosAppStore,
        /// <summary>
        /// 
        /// </summary>
        MacAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        MacAppDirect,
        /// <summary>
        /// 
        /// </summary>
        MacAppStore,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppDirect,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppStore,
        /// <summary>
        /// 
        /// </summary>
        TvosAppAdhoc,
        /// <summary>
        /// 
        /// </summary>
        TvosAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        TvosAppInhouse,
        /// <summary>
        /// 
        /// </summary>
        TvosAppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileCreateRequestDataAttributesProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileCreateRequestDataAttributesProfileType value)
        {
            return value switch
            {
                ProfileCreateRequestDataAttributesProfileType.IosAppAdhoc => "IOS_APP_ADHOC",
                ProfileCreateRequestDataAttributesProfileType.IosAppDevelopment => "IOS_APP_DEVELOPMENT",
                ProfileCreateRequestDataAttributesProfileType.IosAppInhouse => "IOS_APP_INHOUSE",
                ProfileCreateRequestDataAttributesProfileType.IosAppStore => "IOS_APP_STORE",
                ProfileCreateRequestDataAttributesProfileType.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                ProfileCreateRequestDataAttributesProfileType.MacAppDirect => "MAC_APP_DIRECT",
                ProfileCreateRequestDataAttributesProfileType.MacAppStore => "MAC_APP_STORE",
                ProfileCreateRequestDataAttributesProfileType.MacCatalystAppDevelopment => "MAC_CATALYST_APP_DEVELOPMENT",
                ProfileCreateRequestDataAttributesProfileType.MacCatalystAppDirect => "MAC_CATALYST_APP_DIRECT",
                ProfileCreateRequestDataAttributesProfileType.MacCatalystAppStore => "MAC_CATALYST_APP_STORE",
                ProfileCreateRequestDataAttributesProfileType.TvosAppAdhoc => "TVOS_APP_ADHOC",
                ProfileCreateRequestDataAttributesProfileType.TvosAppDevelopment => "TVOS_APP_DEVELOPMENT",
                ProfileCreateRequestDataAttributesProfileType.TvosAppInhouse => "TVOS_APP_INHOUSE",
                ProfileCreateRequestDataAttributesProfileType.TvosAppStore => "TVOS_APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileCreateRequestDataAttributesProfileType? ToEnum(string value)
        {
            return value switch
            {
                "IOS_APP_ADHOC" => ProfileCreateRequestDataAttributesProfileType.IosAppAdhoc,
                "IOS_APP_DEVELOPMENT" => ProfileCreateRequestDataAttributesProfileType.IosAppDevelopment,
                "IOS_APP_INHOUSE" => ProfileCreateRequestDataAttributesProfileType.IosAppInhouse,
                "IOS_APP_STORE" => ProfileCreateRequestDataAttributesProfileType.IosAppStore,
                "MAC_APP_DEVELOPMENT" => ProfileCreateRequestDataAttributesProfileType.MacAppDevelopment,
                "MAC_APP_DIRECT" => ProfileCreateRequestDataAttributesProfileType.MacAppDirect,
                "MAC_APP_STORE" => ProfileCreateRequestDataAttributesProfileType.MacAppStore,
                "MAC_CATALYST_APP_DEVELOPMENT" => ProfileCreateRequestDataAttributesProfileType.MacCatalystAppDevelopment,
                "MAC_CATALYST_APP_DIRECT" => ProfileCreateRequestDataAttributesProfileType.MacCatalystAppDirect,
                "MAC_CATALYST_APP_STORE" => ProfileCreateRequestDataAttributesProfileType.MacCatalystAppStore,
                "TVOS_APP_ADHOC" => ProfileCreateRequestDataAttributesProfileType.TvosAppAdhoc,
                "TVOS_APP_DEVELOPMENT" => ProfileCreateRequestDataAttributesProfileType.TvosAppDevelopment,
                "TVOS_APP_INHOUSE" => ProfileCreateRequestDataAttributesProfileType.TvosAppInhouse,
                "TVOS_APP_STORE" => ProfileCreateRequestDataAttributesProfileType.TvosAppStore,
                _ => null,
            };
        }
    }
}