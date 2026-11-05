
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsGetInstanceFieldsRetentionMessage
    {
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsGetInstanceFieldsRetentionMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsGetInstanceFieldsRetentionMessage value)
        {
            return value switch
            {
                RetentionMessageVersionsGetInstanceFieldsRetentionMessage.ReferenceName => "referenceName",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessage.Subscriptions => "subscriptions",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessage.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsGetInstanceFieldsRetentionMessage? ToEnum(string value)
        {
            return value switch
            {
                "referenceName" => RetentionMessageVersionsGetInstanceFieldsRetentionMessage.ReferenceName,
                "subscriptions" => RetentionMessageVersionsGetInstanceFieldsRetentionMessage.Subscriptions,
                "versions" => RetentionMessageVersionsGetInstanceFieldsRetentionMessage.Versions,
                _ => null,
            };
        }
    }
}