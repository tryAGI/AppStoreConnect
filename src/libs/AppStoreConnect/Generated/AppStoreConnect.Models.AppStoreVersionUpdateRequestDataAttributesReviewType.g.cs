
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionUpdateRequestDataAttributesReviewType
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
    public static class AppStoreVersionUpdateRequestDataAttributesReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionUpdateRequestDataAttributesReviewType value)
        {
            return value switch
            {
                AppStoreVersionUpdateRequestDataAttributesReviewType.AppStore => "APP_STORE",
                AppStoreVersionUpdateRequestDataAttributesReviewType.Notarization => "NOTARIZATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionUpdateRequestDataAttributesReviewType? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE" => AppStoreVersionUpdateRequestDataAttributesReviewType.AppStore,
                "NOTARIZATION" => AppStoreVersionUpdateRequestDataAttributesReviewType.Notarization,
                _ => null,
            };
        }
    }
}