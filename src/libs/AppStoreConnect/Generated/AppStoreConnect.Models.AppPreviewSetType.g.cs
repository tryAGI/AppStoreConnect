
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetType value)
        {
            return value switch
            {
                AppPreviewSetType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppPreviewSetType.AppPreviewSets,
                _ => null,
            };
        }
    }
}