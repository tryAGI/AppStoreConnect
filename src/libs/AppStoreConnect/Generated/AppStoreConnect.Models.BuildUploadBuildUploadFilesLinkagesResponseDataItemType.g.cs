
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadBuildUploadFilesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadBuildUploadFilesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadBuildUploadFilesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildUploadBuildUploadFilesLinkagesResponseDataItemType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadBuildUploadFilesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadBuildUploadFilesLinkagesResponseDataItemType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}