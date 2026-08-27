
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetInstanceFieldsBuildUpload
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
    public static class BuildsGetInstanceFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBuildUpload value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                BuildsGetInstanceFieldsBuildUpload.AssetFile => "assetFile",
                BuildsGetInstanceFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                BuildsGetInstanceFieldsBuildUpload.Build => "build",
                BuildsGetInstanceFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                BuildsGetInstanceFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                BuildsGetInstanceFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                BuildsGetInstanceFieldsBuildUpload.CreatedDate => "createdDate",
                BuildsGetInstanceFieldsBuildUpload.Platform => "platform",
                BuildsGetInstanceFieldsBuildUpload.State => "state",
                BuildsGetInstanceFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => BuildsGetInstanceFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => BuildsGetInstanceFieldsBuildUpload.AssetFile,
                "assetSpiFile" => BuildsGetInstanceFieldsBuildUpload.AssetSpiFile,
                "build" => BuildsGetInstanceFieldsBuildUpload.Build,
                "buildUploadFiles" => BuildsGetInstanceFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => BuildsGetInstanceFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => BuildsGetInstanceFieldsBuildUpload.CfBundleVersion,
                "createdDate" => BuildsGetInstanceFieldsBuildUpload.CreatedDate,
                "platform" => BuildsGetInstanceFieldsBuildUpload.Platform,
                "state" => BuildsGetInstanceFieldsBuildUpload.State,
                "uploadedDate" => BuildsGetInstanceFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}