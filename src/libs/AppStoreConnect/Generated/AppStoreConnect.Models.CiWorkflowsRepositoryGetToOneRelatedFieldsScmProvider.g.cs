
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider
    {
        /// <summary>
        ///
        /// </summary>
        Repositories,
        /// <summary>
        ///
        /// </summary>
        ScmProviderType,
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsRepositoryGetToOneRelatedFieldsScmProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider value)
        {
            return value switch
            {
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.Repositories => "repositories",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.ScmProviderType => "scmProviderType",
                CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider? ToEnum(string value)
        {
            return value switch
            {
                "repositories" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.Repositories,
                "scmProviderType" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.ScmProviderType,
                "url" => CiWorkflowsRepositoryGetToOneRelatedFieldsScmProvider.Url,
                _ => null,
            };
        }
    }
}