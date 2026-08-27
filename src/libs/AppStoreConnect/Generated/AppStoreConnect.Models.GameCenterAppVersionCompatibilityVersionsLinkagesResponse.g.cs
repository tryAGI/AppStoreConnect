
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAppVersionCompatibilityVersionsLinkagesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionCompatibilityVersionsLinkagesResponseDataItem> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.PagedDocumentLinks Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::AppStoreConnect.PagingInformation? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionCompatibilityVersionsLinkagesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAppVersionCompatibilityVersionsLinkagesResponse(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionCompatibilityVersionsLinkagesResponseDataItem> data,
            global::AppStoreConnect.PagedDocumentLinks links,
            global::AppStoreConnect.PagingInformation? meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionCompatibilityVersionsLinkagesResponse" /> class.
        /// </summary>
        public GameCenterAppVersionCompatibilityVersionsLinkagesResponse()
        {
        }

    }
}