
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CapabilitySettingKey
    {
        /// <summary>
        /// 
        /// </summary>
        AppleIdAuthAppConsent,
        /// <summary>
        /// 
        /// </summary>
        DataProtectionPermissionLevel,
        /// <summary>
        /// 
        /// </summary>
        IcloudVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilitySettingKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilitySettingKey value)
        {
            return value switch
            {
                CapabilitySettingKey.AppleIdAuthAppConsent => "APPLE_ID_AUTH_APP_CONSENT",
                CapabilitySettingKey.DataProtectionPermissionLevel => "DATA_PROTECTION_PERMISSION_LEVEL",
                CapabilitySettingKey.IcloudVersion => "ICLOUD_VERSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilitySettingKey? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_ID_AUTH_APP_CONSENT" => CapabilitySettingKey.AppleIdAuthAppConsent,
                "DATA_PROTECTION_PERMISSION_LEVEL" => CapabilitySettingKey.DataProtectionPermissionLevel,
                "ICLOUD_VERSION" => CapabilitySettingKey.IcloudVersion,
                _ => null,
            };
        }
    }
}