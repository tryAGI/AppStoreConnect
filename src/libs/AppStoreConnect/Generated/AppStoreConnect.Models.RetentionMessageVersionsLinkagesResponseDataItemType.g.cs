
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                RetentionMessageVersionsLinkagesResponseDataItemType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageVersionsLinkagesResponseDataItemType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}