
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail
    {
        /// <summary>
        ///
        /// </summary>
        AutoNotifyEnabled,
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        ExternalBuildState,
        /// <summary>
        ///
        /// </summary>
        InternalBuildState,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.Build => "build",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildsBuildBetaDetailGetToOneRelatedFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}