
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedFieldsBuildUpload
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
    public static class AppsBuildUploadsGetToManyRelatedFieldsBuildUploadExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedFieldsBuildUpload value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetDescriptionFile => "assetDescriptionFile",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetFile => "assetFile",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetSpiFile => "assetSpiFile",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.Build => "build",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.BuildUploadFiles => "buildUploadFiles",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CfBundleShortVersionString => "cfBundleShortVersionString",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CfBundleVersion => "cfBundleVersion",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CreatedDate => "createdDate",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.Platform => "platform",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.State => "state",
                AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.UploadedDate => "uploadedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedFieldsBuildUpload? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetDescriptionFile,
                "assetFile" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetFile,
                "assetSpiFile" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.AssetSpiFile,
                "build" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.Build,
                "buildUploadFiles" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.BuildUploadFiles,
                "cfBundleShortVersionString" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CfBundleShortVersionString,
                "cfBundleVersion" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CfBundleVersion,
                "createdDate" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.CreatedDate,
                "platform" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.Platform,
                "state" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.State,
                "uploadedDate" => AppsBuildUploadsGetToManyRelatedFieldsBuildUpload.UploadedDate,
                _ => null,
            };
        }
    }
}