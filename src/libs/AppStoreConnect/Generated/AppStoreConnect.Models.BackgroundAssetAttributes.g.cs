
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetPackIdentifier")]
        public string? AssetPackIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedBytes")]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetAttributes" /> class.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="assetPackIdentifier"></param>
        /// <param name="createdDate"></param>
        /// <param name="usedBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetAttributes(
            bool? archived,
            string? assetPackIdentifier,
            global::System.DateTime? createdDate,
            long? usedBytes)
        {
            this.Archived = archived;
            this.AssetPackIdentifier = assetPackIdentifier;
            this.CreatedDate = createdDate;
            this.UsedBytes = usedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetAttributes" /> class.
        /// </summary>
        public BackgroundAssetAttributes()
        {
        }

    }
}