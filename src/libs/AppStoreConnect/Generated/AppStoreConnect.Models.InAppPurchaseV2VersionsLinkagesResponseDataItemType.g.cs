
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2VersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2VersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2VersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2VersionsLinkagesResponseDataItemType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2VersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => InAppPurchaseV2VersionsLinkagesResponseDataItemType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}