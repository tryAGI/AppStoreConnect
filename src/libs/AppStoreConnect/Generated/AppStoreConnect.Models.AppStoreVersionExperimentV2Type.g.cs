
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentV2Type
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2Type value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2Type.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2Type? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionExperimentV2Type.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}