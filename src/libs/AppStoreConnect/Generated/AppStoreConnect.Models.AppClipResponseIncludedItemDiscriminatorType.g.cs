
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences,
                "apps" => AppClipResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}