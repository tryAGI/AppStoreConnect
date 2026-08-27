
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu
    {
        /// <summary>
        /// 
        /// </summary>
        Matched,
        /// <summary>
        /// 
        /// </summary>
        NoMatch,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.Matched => "MATCHED",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.NoMatch => "NO_MATCH",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.Pending => "PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu? ToEnum(string value)
        {
            return value switch
            {
                "MATCHED" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.Matched,
                "NO_MATCH" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.NoMatch,
                "PENDING" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterPlaceStatu.Pending,
                _ => null,
            };
        }
    }
}