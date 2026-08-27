
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionCreateRequestDataAttributesReviewType
    {
        /// <summary>
        ///
        /// </summary>
        AppStore,
        /// <summary>
        ///
        /// </summary>
        Notarization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionCreateRequestDataAttributesReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionCreateRequestDataAttributesReviewType value)
        {
            return value switch
            {
                AppStoreVersionCreateRequestDataAttributesReviewType.AppStore => "APP_STORE",
                AppStoreVersionCreateRequestDataAttributesReviewType.Notarization => "NOTARIZATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionCreateRequestDataAttributesReviewType? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE" => AppStoreVersionCreateRequestDataAttributesReviewType.AppStore,
                "NOTARIZATION" => AppStoreVersionCreateRequestDataAttributesReviewType.Notarization,
                _ => null,
            };
        }
    }
}