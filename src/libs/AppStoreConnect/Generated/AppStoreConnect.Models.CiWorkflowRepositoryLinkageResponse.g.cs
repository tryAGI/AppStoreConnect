
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiWorkflowRepositoryLinkageResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseData Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.DocumentLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRepositoryLinkageResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowRepositoryLinkageResponse(
            global::AppStoreConnect.CiWorkflowRepositoryLinkageResponseData data,
            global::AppStoreConnect.DocumentLinks links)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowRepositoryLinkageResponse" /> class.
        /// </summary>
        public CiWorkflowRepositoryLinkageResponse()
        {
        }

    }
}