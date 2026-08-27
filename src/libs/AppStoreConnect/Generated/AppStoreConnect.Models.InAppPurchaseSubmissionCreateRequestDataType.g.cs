
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseSubmissionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseSubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseSubmissionCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseSubmissionCreateRequestDataType.InAppPurchaseSubmissions => "inAppPurchaseSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseSubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseSubmissions" => InAppPurchaseSubmissionCreateRequestDataType.InAppPurchaseSubmissions,
                _ => null,
            };
        }
    }
}