
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType value)
        {
            return value switch
            {
                InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseSubmissionCreateRequestDataRelationshipsInAppPurchaseV2DataType.InAppPurchases,
                _ => null,
            };
        }
    }
}