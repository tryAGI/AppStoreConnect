
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                RetentionMessageVersionRelationshipsLocalizationsDataItemType.RetentionMessageLocalizations => "retentionMessageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageLocalizations" => RetentionMessageVersionRelationshipsLocalizationsDataItemType.RetentionMessageLocalizations,
                _ => null,
            };
        }
    }
}