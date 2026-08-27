
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize
    {
        /// <summary>
        ///
        /// </summary>
        DeviceModel,
        /// <summary>
        ///
        /// </summary>
        DownloadBytes,
        /// <summary>
        ///
        /// </summary>
        InstallBytes,
        /// <summary>
        ///
        /// </summary>
        OsVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize value)
        {
            return value switch
            {
                BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.DeviceModel => "deviceModel",
                BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.DownloadBytes => "downloadBytes",
                BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.InstallBytes => "installBytes",
                BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.OsVersion => "osVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize? ToEnum(string value)
        {
            return value switch
            {
                "deviceModel" => BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.DeviceModel,
                "downloadBytes" => BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.DownloadBytes,
                "installBytes" => BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.InstallBytes,
                "osVersion" => BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize.OsVersion,
                _ => null,
            };
        }
    }
}