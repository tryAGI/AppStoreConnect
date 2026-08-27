
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetPackIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetPackIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="assetPackIdentifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetCreateRequestDataAttributes(
            string assetPackIdentifier)
        {
            this.AssetPackIdentifier = assetPackIdentifier ?? throw new global::System.ArgumentNullException(nameof(assetPackIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetCreateRequestDataAttributes" /> class.
        /// </summary>
        public BackgroundAssetCreateRequestDataAttributes()
        {
        }

    }
}