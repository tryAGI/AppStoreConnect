
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppUpdateRequestDataAttributesGroupPurchaseInvitationMode
    {
        /// <summary>
        ///
        /// </summary>
        AppleHosted,
        /// <summary>
        ///
        /// </summary>
        DeveloperHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppUpdateRequestDataAttributesGroupPurchaseInvitationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppUpdateRequestDataAttributesGroupPurchaseInvitationMode value)
        {
            return value switch
            {
                AppUpdateRequestDataAttributesGroupPurchaseInvitationMode.AppleHosted => "APPLE_HOSTED",
                AppUpdateRequestDataAttributesGroupPurchaseInvitationMode.DeveloperHosted => "DEVELOPER_HOSTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppUpdateRequestDataAttributesGroupPurchaseInvitationMode? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_HOSTED" => AppUpdateRequestDataAttributesGroupPurchaseInvitationMode.AppleHosted,
                "DEVELOPER_HOSTED" => AppUpdateRequestDataAttributesGroupPurchaseInvitationMode.DeveloperHosted,
                _ => null,
            };
        }
    }
}