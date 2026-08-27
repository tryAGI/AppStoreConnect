
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact
    {
        /// <summary>
        ///
        /// </summary>
        DownloadUrl,
        /// <summary>
        ///
        /// </summary>
        FileName,
        /// <summary>
        ///
        /// </summary>
        FileSize,
        /// <summary>
        ///
        /// </summary>
        FileType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifactExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact value)
        {
            return value switch
            {
                CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.DownloadUrl => "downloadUrl",
                CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileName => "fileName",
                CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileSize => "fileSize",
                CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileType => "fileType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact? ToEnum(string value)
        {
            return value switch
            {
                "downloadUrl" => CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.DownloadUrl,
                "fileName" => CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileName,
                "fileSize" => CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileSize,
                "fileType" => CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact.FileType,
                _ => null,
            };
        }
    }
}