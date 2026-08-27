
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType value)
        {
            return value switch
            {
                AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}