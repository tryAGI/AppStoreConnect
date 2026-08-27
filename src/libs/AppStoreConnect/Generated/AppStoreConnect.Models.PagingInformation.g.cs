
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PagingInformation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paging")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.PagingInformationPaging Paging { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingInformation" /> class.
        /// </summary>
        /// <param name="paging"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagingInformation(
            global::AppStoreConnect.PagingInformationPaging paging)
        {
            this.Paging = paging ?? throw new global::System.ArgumentNullException(nameof(paging));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagingInformation" /> class.
        /// </summary>
        public PagingInformation()
        {
        }

    }
}