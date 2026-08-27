
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PromotedPurchaseCreateRequestDataRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchaseCreateRequestDataRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchaseCreateRequestDataRelationshipsAppDataType value)
        {
            return value switch
            {
                PromotedPurchaseCreateRequestDataRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchaseCreateRequestDataRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => PromotedPurchaseCreateRequestDataRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}