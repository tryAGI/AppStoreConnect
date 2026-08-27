
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventCreateRequestDataAttributesBadge
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Competition,
        /// <summary>
        ///
        /// </summary>
        LiveEvent,
        /// <summary>
        ///
        /// </summary>
        MajorUpdate,
        /// <summary>
        ///
        /// </summary>
        NewSeason,
        /// <summary>
        ///
        /// </summary>
        Premiere,
        /// <summary>
        ///
        /// </summary>
        SpecialEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventCreateRequestDataAttributesBadgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventCreateRequestDataAttributesBadge value)
        {
            return value switch
            {
                AppEventCreateRequestDataAttributesBadge.Challenge => "CHALLENGE",
                AppEventCreateRequestDataAttributesBadge.Competition => "COMPETITION",
                AppEventCreateRequestDataAttributesBadge.LiveEvent => "LIVE_EVENT",
                AppEventCreateRequestDataAttributesBadge.MajorUpdate => "MAJOR_UPDATE",
                AppEventCreateRequestDataAttributesBadge.NewSeason => "NEW_SEASON",
                AppEventCreateRequestDataAttributesBadge.Premiere => "PREMIERE",
                AppEventCreateRequestDataAttributesBadge.SpecialEvent => "SPECIAL_EVENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventCreateRequestDataAttributesBadge? ToEnum(string value)
        {
            return value switch
            {
                "CHALLENGE" => AppEventCreateRequestDataAttributesBadge.Challenge,
                "COMPETITION" => AppEventCreateRequestDataAttributesBadge.Competition,
                "LIVE_EVENT" => AppEventCreateRequestDataAttributesBadge.LiveEvent,
                "MAJOR_UPDATE" => AppEventCreateRequestDataAttributesBadge.MajorUpdate,
                "NEW_SEASON" => AppEventCreateRequestDataAttributesBadge.NewSeason,
                "PREMIERE" => AppEventCreateRequestDataAttributesBadge.Premiere,
                "SPECIAL_EVENT" => AppEventCreateRequestDataAttributesBadge.SpecialEvent,
                _ => null,
            };
        }
    }
}