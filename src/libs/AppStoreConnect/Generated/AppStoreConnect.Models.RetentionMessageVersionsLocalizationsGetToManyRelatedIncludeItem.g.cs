
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItem.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersion" => RetentionMessageVersionsLocalizationsGetToManyRelatedIncludeItem.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}