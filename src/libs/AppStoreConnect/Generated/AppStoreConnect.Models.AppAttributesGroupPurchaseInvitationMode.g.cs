
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAttributesGroupPurchaseInvitationMode
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
    public static class AppAttributesGroupPurchaseInvitationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAttributesGroupPurchaseInvitationMode value)
        {
            return value switch
            {
                AppAttributesGroupPurchaseInvitationMode.AppleHosted => "APPLE_HOSTED",
                AppAttributesGroupPurchaseInvitationMode.DeveloperHosted => "DEVELOPER_HOSTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAttributesGroupPurchaseInvitationMode? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_HOSTED" => AppAttributesGroupPurchaseInvitationMode.AppleHosted,
                "DEVELOPER_HOSTED" => AppAttributesGroupPurchaseInvitationMode.DeveloperHosted,
                _ => null,
            };
        }
    }
}