
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion
    {
        /// <summary>
        ///
        /// </summary>
        Activity,
        /// <summary>
        ///
        /// </summary>
        DefaultImage,
        /// <summary>
        ///
        /// </summary>
        FallbackUrl,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Releases,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}