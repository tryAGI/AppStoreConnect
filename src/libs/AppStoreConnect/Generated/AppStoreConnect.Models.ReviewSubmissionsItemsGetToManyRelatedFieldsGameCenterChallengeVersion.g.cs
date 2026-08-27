
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        DefaultImage,
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}