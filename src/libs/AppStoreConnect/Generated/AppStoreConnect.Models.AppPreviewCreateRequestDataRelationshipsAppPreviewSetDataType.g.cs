
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataType value)
        {
            return value switch
            {
                AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppPreviewCreateRequestDataRelationshipsAppPreviewSetDataType.AppPreviewSets,
                _ => null,
            };
        }
    }
}