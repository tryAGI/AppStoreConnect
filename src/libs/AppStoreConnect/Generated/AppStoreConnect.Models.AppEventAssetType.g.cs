
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventAssetType
    {
        /// <summary>
        ///
        /// </summary>
        EventCard,
        /// <summary>
        ///
        /// </summary>
        EventDetailsPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventAssetType value)
        {
            return value switch
            {
                AppEventAssetType.EventCard => "EVENT_CARD",
                AppEventAssetType.EventDetailsPage => "EVENT_DETAILS_PAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventAssetType? ToEnum(string value)
        {
            return value switch
            {
                "EVENT_CARD" => AppEventAssetType.EventCard,
                "EVENT_DETAILS_PAGE" => AppEventAssetType.EventDetailsPage,
                _ => null,
            };
        }
    }
}