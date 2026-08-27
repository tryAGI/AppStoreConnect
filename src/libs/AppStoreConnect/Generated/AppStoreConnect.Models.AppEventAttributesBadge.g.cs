
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventAttributesBadge
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
    public static class AppEventAttributesBadgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventAttributesBadge value)
        {
            return value switch
            {
                AppEventAttributesBadge.Challenge => "CHALLENGE",
                AppEventAttributesBadge.Competition => "COMPETITION",
                AppEventAttributesBadge.LiveEvent => "LIVE_EVENT",
                AppEventAttributesBadge.MajorUpdate => "MAJOR_UPDATE",
                AppEventAttributesBadge.NewSeason => "NEW_SEASON",
                AppEventAttributesBadge.Premiere => "PREMIERE",
                AppEventAttributesBadge.SpecialEvent => "SPECIAL_EVENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventAttributesBadge? ToEnum(string value)
        {
            return value switch
            {
                "CHALLENGE" => AppEventAttributesBadge.Challenge,
                "COMPETITION" => AppEventAttributesBadge.Competition,
                "LIVE_EVENT" => AppEventAttributesBadge.LiveEvent,
                "MAJOR_UPDATE" => AppEventAttributesBadge.MajorUpdate,
                "NEW_SEASON" => AppEventAttributesBadge.NewSeason,
                "PREMIERE" => AppEventAttributesBadge.Premiere,
                "SPECIAL_EVENT" => AppEventAttributesBadge.SpecialEvent,
                _ => null,
            };
        }
    }
}