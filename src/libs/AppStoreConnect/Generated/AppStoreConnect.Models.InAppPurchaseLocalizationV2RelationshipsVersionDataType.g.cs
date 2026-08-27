
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationV2RelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationV2RelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationV2RelationshipsVersionDataType value)
        {
            return value switch
            {
                InAppPurchaseLocalizationV2RelationshipsVersionDataType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationV2RelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => InAppPurchaseLocalizationV2RelationshipsVersionDataType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}