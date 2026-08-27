
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseSubmissionType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseSubmissionType value)
        {
            return value switch
            {
                InAppPurchaseSubmissionType.InAppPurchaseSubmissions => "inAppPurchaseSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseSubmissions" => InAppPurchaseSubmissionType.InAppPurchaseSubmissions,
                _ => null,
            };
        }
    }
}