
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => ReviewSubmissionItemRelationshipsInAppPurchaseVersionDataType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}