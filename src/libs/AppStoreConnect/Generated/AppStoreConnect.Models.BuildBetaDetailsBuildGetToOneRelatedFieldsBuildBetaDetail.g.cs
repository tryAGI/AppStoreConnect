
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.AutoNotifyEnabled => "autoNotifyEnabled",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.Build => "build",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.ExternalBuildState => "externalBuildState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.InternalBuildState => "internalBuildState",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail? ToEnum(string value)
        {
            return value switch
            {
                "autoNotifyEnabled" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.AutoNotifyEnabled,
                "build" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.Build,
                "externalBuildState" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.ExternalBuildState,
                "internalBuildState" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail.InternalBuildState,
                _ => null,
            };
        }
    }
}