
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBuildUpload
    {
        /// <summary>
        /// 
        /// </summary>
        AssetDescriptionFile,
        /// <summary>
        /// 
        /// </summary>
        AssetFile,
        /// <summary>
        /// 
        /// </summary>
        AssetSpiFile,
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        BuildUploadFiles,
        /// <summary>
        /// 
        /// </summary>
        CfBundleShortVersionString,
        /// <summary>
        /// 
        /// </summary>
        CfBundleVersion,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        UploadedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetCollectionFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBuildUpload value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                BuildsGetCollectionFieldsBuildUpload.AssetFile => "assetFile",
                BuildsGetCollectionFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                BuildsGetCollectionFieldsBuildUpload.Build => "build",
                BuildsGetCollectionFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                BuildsGetCollectionFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                BuildsGetCollectionFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                BuildsGetCollectionFieldsBuildUpload.CreatedDate => "createdDate",
                BuildsGetCollectionFieldsBuildUpload.Platform => "platform",
                BuildsGetCollectionFieldsBuildUpload.State => "state",
                BuildsGetCollectionFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => BuildsGetCollectionFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => BuildsGetCollectionFieldsBuildUpload.AssetFile,
                "assetSpiFile" => BuildsGetCollectionFieldsBuildUpload.AssetSpiFile,
                "build" => BuildsGetCollectionFieldsBuildUpload.Build,
                "buildUploadFiles" => BuildsGetCollectionFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => BuildsGetCollectionFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => BuildsGetCollectionFieldsBuildUpload.CfBundleVersion,
                "createdDate" => BuildsGetCollectionFieldsBuildUpload.CreatedDate,
                "platform" => BuildsGetCollectionFieldsBuildUpload.Platform,
                "state" => BuildsGetCollectionFieldsBuildUpload.State,
                "uploadedDate" => BuildsGetCollectionFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}