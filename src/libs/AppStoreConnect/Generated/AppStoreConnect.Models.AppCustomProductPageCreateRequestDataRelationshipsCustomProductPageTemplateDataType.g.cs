
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType value)
        {
            return value switch
            {
                AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}