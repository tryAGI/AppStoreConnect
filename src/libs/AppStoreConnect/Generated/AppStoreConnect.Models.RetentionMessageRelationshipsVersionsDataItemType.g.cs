
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                RetentionMessageRelationshipsVersionsDataItemType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageRelationshipsVersionsDataItemType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}