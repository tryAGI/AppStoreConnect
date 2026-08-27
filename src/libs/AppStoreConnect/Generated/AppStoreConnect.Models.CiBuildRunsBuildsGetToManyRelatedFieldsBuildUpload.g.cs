
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetFile => "assetFile",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.Build => "build",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CreatedDate => "createdDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.Platform => "platform",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.State => "state",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetFile,
                "assetSpiFile" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.AssetSpiFile,
                "build" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.Build,
                "buildUploadFiles" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CfBundleVersion,
                "createdDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.CreatedDate,
                "platform" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.Platform,
                "state" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.State,
                "uploadedDate" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}