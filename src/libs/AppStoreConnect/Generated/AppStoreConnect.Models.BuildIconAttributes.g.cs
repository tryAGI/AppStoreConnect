
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildIconAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconAsset")]
        public global::AppStoreConnect.ImageAsset? IconAsset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.IconAssetTypeJsonConverter))]
        public global::AppStoreConnect.IconAssetType? IconType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masked")]
        public bool? Masked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIconAttributes" /> class.
        /// </summary>
        /// <param name="iconAsset"></param>
        /// <param name="iconType"></param>
        /// <param name="masked"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildIconAttributes(
            global::AppStoreConnect.ImageAsset? iconAsset,
            global::AppStoreConnect.IconAssetType? iconType,
            bool? masked,
            string? name)
        {
            this.IconAsset = iconAsset;
            this.IconType = iconType;
            this.Masked = masked;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildIconAttributes" /> class.
        /// </summary>
        public BuildIconAttributes()
        {
        }

    }
}