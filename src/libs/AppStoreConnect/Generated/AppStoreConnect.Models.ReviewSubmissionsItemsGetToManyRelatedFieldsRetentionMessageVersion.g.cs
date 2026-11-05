
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Placement,
        /// <summary>
        ///
        /// </summary>
        RetentionMessage,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}