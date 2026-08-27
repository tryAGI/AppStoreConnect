
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => InAppPurchaseImageV2CreateRequestDataRelationshipsVersionDataType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}