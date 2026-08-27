
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventUpdateRequestDataAttributesBadge
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
    public static class AppEventUpdateRequestDataAttributesBadgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventUpdateRequestDataAttributesBadge value)
        {
            return value switch
            {
                AppEventUpdateRequestDataAttributesBadge.Challenge => "CHALLENGE",
                AppEventUpdateRequestDataAttributesBadge.Competition => "COMPETITION",
                AppEventUpdateRequestDataAttributesBadge.LiveEvent => "LIVE_EVENT",
                AppEventUpdateRequestDataAttributesBadge.MajorUpdate => "MAJOR_UPDATE",
                AppEventUpdateRequestDataAttributesBadge.NewSeason => "NEW_SEASON",
                AppEventUpdateRequestDataAttributesBadge.Premiere => "PREMIERE",
                AppEventUpdateRequestDataAttributesBadge.SpecialEvent => "SPECIAL_EVENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventUpdateRequestDataAttributesBadge? ToEnum(string value)
        {
            return value switch
            {
                "CHALLENGE" => AppEventUpdateRequestDataAttributesBadge.Challenge,
                "COMPETITION" => AppEventUpdateRequestDataAttributesBadge.Competition,
                "LIVE_EVENT" => AppEventUpdateRequestDataAttributesBadge.LiveEvent,
                "MAJOR_UPDATE" => AppEventUpdateRequestDataAttributesBadge.MajorUpdate,
                "NEW_SEASON" => AppEventUpdateRequestDataAttributesBadge.NewSeason,
                "PREMIERE" => AppEventUpdateRequestDataAttributesBadge.Premiere,
                "SPECIAL_EVENT" => AppEventUpdateRequestDataAttributesBadge.SpecialEvent,
                _ => null,
            };
        }
    }
}