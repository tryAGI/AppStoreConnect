
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmRepositoryRelationshipsScmProviderDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmProviders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoryRelationshipsScmProviderDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoryRelationshipsScmProviderDataType value)
        {
            return value switch
            {
                ScmRepositoryRelationshipsScmProviderDataType.ScmProviders => "scmProviders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoryRelationshipsScmProviderDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmProviders" => ScmRepositoryRelationshipsScmProviderDataType.ScmProviders,
                _ => null,
            };
        }
    }
}