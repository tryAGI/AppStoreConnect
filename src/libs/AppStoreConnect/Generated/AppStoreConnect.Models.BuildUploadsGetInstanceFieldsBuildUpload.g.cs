
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadsGetInstanceFieldsBuildUpload
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
    public static class BuildUploadsGetInstanceFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsGetInstanceFieldsBuildUpload value)
        {
            return value switch
            {
                BuildUploadsGetInstanceFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                BuildUploadsGetInstanceFieldsBuildUpload.AssetFile => "assetFile",
                BuildUploadsGetInstanceFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                BuildUploadsGetInstanceFieldsBuildUpload.Build => "build",
                BuildUploadsGetInstanceFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                BuildUploadsGetInstanceFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                BuildUploadsGetInstanceFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                BuildUploadsGetInstanceFieldsBuildUpload.CreatedDate => "createdDate",
                BuildUploadsGetInstanceFieldsBuildUpload.Platform => "platform",
                BuildUploadsGetInstanceFieldsBuildUpload.State => "state",
                BuildUploadsGetInstanceFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsGetInstanceFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => BuildUploadsGetInstanceFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => BuildUploadsGetInstanceFieldsBuildUpload.AssetFile,
                "assetSpiFile" => BuildUploadsGetInstanceFieldsBuildUpload.AssetSpiFile,
                "build" => BuildUploadsGetInstanceFieldsBuildUpload.Build,
                "buildUploadFiles" => BuildUploadsGetInstanceFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => BuildUploadsGetInstanceFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => BuildUploadsGetInstanceFieldsBuildUpload.CfBundleVersion,
                "createdDate" => BuildUploadsGetInstanceFieldsBuildUpload.CreatedDate,
                "platform" => BuildUploadsGetInstanceFieldsBuildUpload.Platform,
                "state" => BuildUploadsGetInstanceFieldsBuildUpload.State,
                "uploadedDate" => BuildUploadsGetInstanceFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}