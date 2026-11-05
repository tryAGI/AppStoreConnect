
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageResponseIncludedItemDiscriminatorType
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
    public static class RetentionMessageResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionMessageResponseIncludedItemDiscriminatorType.RetentionMessageVersions => "retentionMessageVersions",
                RetentionMessageResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageResponseIncludedItemDiscriminatorType.RetentionMessageVersions,
                "subscriptions" => RetentionMessageResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}