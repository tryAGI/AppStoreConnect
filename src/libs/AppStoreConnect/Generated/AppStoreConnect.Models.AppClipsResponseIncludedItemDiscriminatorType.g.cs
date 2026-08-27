
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsResponseIncludedItemDiscriminatorType
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
    public static class AppClipsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipsResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences,
                "apps" => AppClipsResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}