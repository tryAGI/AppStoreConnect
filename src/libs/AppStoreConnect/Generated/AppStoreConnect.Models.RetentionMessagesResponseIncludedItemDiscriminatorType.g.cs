
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionMessagesResponseIncludedItemDiscriminatorType.RetentionMessageVersions => "retentionMessageVersions",
                RetentionMessagesResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessagesResponseIncludedItemDiscriminatorType.RetentionMessageVersions,
                "subscriptions" => RetentionMessagesResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}