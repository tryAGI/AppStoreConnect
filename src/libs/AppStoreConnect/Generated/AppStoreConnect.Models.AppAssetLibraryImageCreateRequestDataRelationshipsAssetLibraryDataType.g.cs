
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType value)
        {
            return value switch
            {
                AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType.AppAssetLibraries => "appAssetLibraries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraries" => AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibraryDataType.AppAssetLibraries,
                _ => null,
            };
        }
    }
}