
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CapabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessWifiInformation,
        /// <summary>
        /// 
        /// </summary>
        AppleIdAuth,
        /// <summary>
        /// 
        /// </summary>
        ApplePay,
        /// <summary>
        /// 
        /// </summary>
        AppGroups,
        /// <summary>
        /// 
        /// </summary>
        AssociatedDomains,
        /// <summary>
        /// 
        /// </summary>
        AutofillCredentialProvider,
        /// <summary>
        /// 
        /// </summary>
        Classkit,
        /// <summary>
        /// 
        /// </summary>
        CoremediaHlsLowLatency,
        /// <summary>
        /// 
        /// </summary>
        DataProtection,
        /// <summary>
        /// 
        /// </summary>
        GameCenter,
        /// <summary>
        /// 
        /// </summary>
        Healthkit,
        /// <summary>
        /// 
        /// </summary>
        Homekit,
        /// <summary>
        /// 
        /// </summary>
        HotSpot,
        /// <summary>
        /// 
        /// </summary>
        Icloud,
        /// <summary>
        /// 
        /// </summary>
        InterAppAudio,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchase,
        /// <summary>
        /// 
        /// </summary>
        Maps,
        /// <summary>
        /// 
        /// </summary>
        Multipath,
        /// <summary>
        /// 
        /// </summary>
        NetworkCustomProtocol,
        /// <summary>
        /// 
        /// </summary>
        NetworkExtensions,
        /// <summary>
        /// 
        /// </summary>
        NfcTagReading,
        /// <summary>
        /// 
        /// </summary>
        PersonalVpn,
        /// <summary>
        /// 
        /// </summary>
        PushNotifications,
        /// <summary>
        /// 
        /// </summary>
        Sirikit,
        /// <summary>
        /// 
        /// </summary>
        SystemExtensionInstall,
        /// <summary>
        /// 
        /// </summary>
        UserManagement,
        /// <summary>
        /// 
        /// </summary>
        Wallet,
        /// <summary>
        /// 
        /// </summary>
        WirelessAccessoryConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilityType value)
        {
            return value switch
            {
                CapabilityType.AccessWifiInformation => "ACCESS_WIFI_INFORMATION",
                CapabilityType.AppleIdAuth => "APPLE_ID_AUTH",
                CapabilityType.ApplePay => "APPLE_PAY",
                CapabilityType.AppGroups => "APP_GROUPS",
                CapabilityType.AssociatedDomains => "ASSOCIATED_DOMAINS",
                CapabilityType.AutofillCredentialProvider => "AUTOFILL_CREDENTIAL_PROVIDER",
                CapabilityType.Classkit => "CLASSKIT",
                CapabilityType.CoremediaHlsLowLatency => "COREMEDIA_HLS_LOW_LATENCY",
                CapabilityType.DataProtection => "DATA_PROTECTION",
                CapabilityType.GameCenter => "GAME_CENTER",
                CapabilityType.Healthkit => "HEALTHKIT",
                CapabilityType.Homekit => "HOMEKIT",
                CapabilityType.HotSpot => "HOT_SPOT",
                CapabilityType.Icloud => "ICLOUD",
                CapabilityType.InterAppAudio => "INTER_APP_AUDIO",
                CapabilityType.InAppPurchase => "IN_APP_PURCHASE",
                CapabilityType.Maps => "MAPS",
                CapabilityType.Multipath => "MULTIPATH",
                CapabilityType.NetworkCustomProtocol => "NETWORK_CUSTOM_PROTOCOL",
                CapabilityType.NetworkExtensions => "NETWORK_EXTENSIONS",
                CapabilityType.NfcTagReading => "NFC_TAG_READING",
                CapabilityType.PersonalVpn => "PERSONAL_VPN",
                CapabilityType.PushNotifications => "PUSH_NOTIFICATIONS",
                CapabilityType.Sirikit => "SIRIKIT",
                CapabilityType.SystemExtensionInstall => "SYSTEM_EXTENSION_INSTALL",
                CapabilityType.UserManagement => "USER_MANAGEMENT",
                CapabilityType.Wallet => "WALLET",
                CapabilityType.WirelessAccessoryConfiguration => "WIRELESS_ACCESSORY_CONFIGURATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilityType? ToEnum(string value)
        {
            return value switch
            {
                "ACCESS_WIFI_INFORMATION" => CapabilityType.AccessWifiInformation,
                "APPLE_ID_AUTH" => CapabilityType.AppleIdAuth,
                "APPLE_PAY" => CapabilityType.ApplePay,
                "APP_GROUPS" => CapabilityType.AppGroups,
                "ASSOCIATED_DOMAINS" => CapabilityType.AssociatedDomains,
                "AUTOFILL_CREDENTIAL_PROVIDER" => CapabilityType.AutofillCredentialProvider,
                "CLASSKIT" => CapabilityType.Classkit,
                "COREMEDIA_HLS_LOW_LATENCY" => CapabilityType.CoremediaHlsLowLatency,
                "DATA_PROTECTION" => CapabilityType.DataProtection,
                "GAME_CENTER" => CapabilityType.GameCenter,
                "HEALTHKIT" => CapabilityType.Healthkit,
                "HOMEKIT" => CapabilityType.Homekit,
                "HOT_SPOT" => CapabilityType.HotSpot,
                "ICLOUD" => CapabilityType.Icloud,
                "INTER_APP_AUDIO" => CapabilityType.InterAppAudio,
                "IN_APP_PURCHASE" => CapabilityType.InAppPurchase,
                "MAPS" => CapabilityType.Maps,
                "MULTIPATH" => CapabilityType.Multipath,
                "NETWORK_CUSTOM_PROTOCOL" => CapabilityType.NetworkCustomProtocol,
                "NETWORK_EXTENSIONS" => CapabilityType.NetworkExtensions,
                "NFC_TAG_READING" => CapabilityType.NfcTagReading,
                "PERSONAL_VPN" => CapabilityType.PersonalVpn,
                "PUSH_NOTIFICATIONS" => CapabilityType.PushNotifications,
                "SIRIKIT" => CapabilityType.Sirikit,
                "SYSTEM_EXTENSION_INSTALL" => CapabilityType.SystemExtensionInstall,
                "USER_MANAGEMENT" => CapabilityType.UserManagement,
                "WALLET" => CapabilityType.Wallet,
                "WIRELESS_ACCESSORY_CONFIGURATION" => CapabilityType.WirelessAccessoryConfiguration,
                _ => null,
            };
        }
    }
}