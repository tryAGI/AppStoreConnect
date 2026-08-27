
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAttributesReviewType
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
    public static class AppStoreVersionAttributesReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAttributesReviewType value)
        {
            return value switch
            {
                AppStoreVersionAttributesReviewType.AppStore => "APP_STORE",
                AppStoreVersionAttributesReviewType.Notarization => "NOTARIZATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAttributesReviewType? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE" => AppStoreVersionAttributesReviewType.AppStore,
                "NOTARIZATION" => AppStoreVersionAttributesReviewType.Notarization,
                _ => null,
            };
        }
    }
}