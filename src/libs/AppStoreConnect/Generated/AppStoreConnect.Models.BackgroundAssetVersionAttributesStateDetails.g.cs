
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetVersionAttributesStateDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? Warnings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infos")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? Infos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAttributesStateDetails" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="warnings"></param>
        /// <param name="infos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionAttributesStateDetails(
            global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? errors,
            global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? warnings,
            global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? infos)
        {
            this.Errors = errors;
            this.Warnings = warnings;
            this.Infos = infos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAttributesStateDetails" /> class.
        /// </summary>
        public BackgroundAssetVersionAttributesStateDetails()
        {
        }

    }
}