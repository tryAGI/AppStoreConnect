
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewRelationshipsAppPreviewSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewRelationshipsAppPreviewSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewRelationshipsAppPreviewSetDataType value)
        {
            return value switch
            {
                AppPreviewRelationshipsAppPreviewSetDataType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewRelationshipsAppPreviewSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppPreviewRelationshipsAppPreviewSetDataType.AppPreviewSets,
                _ => null,
            };
        }
    }
}