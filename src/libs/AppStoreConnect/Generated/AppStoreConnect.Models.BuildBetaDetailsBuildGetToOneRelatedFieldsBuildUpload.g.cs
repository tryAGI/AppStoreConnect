
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetFile => "assetFile",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.Build => "build",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CreatedDate => "createdDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.Platform => "platform",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.State => "state",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetFile,
                "assetSpiFile" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.AssetSpiFile,
                "build" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.Build,
                "buildUploadFiles" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CfBundleVersion,
                "createdDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.CreatedDate,
                "platform" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.Platform,
                "state" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.State,
                "uploadedDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}