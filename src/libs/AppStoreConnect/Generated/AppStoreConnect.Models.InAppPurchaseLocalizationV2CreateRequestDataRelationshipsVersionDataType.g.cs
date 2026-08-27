
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => InAppPurchaseLocalizationV2CreateRequestDataRelationshipsVersionDataType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}