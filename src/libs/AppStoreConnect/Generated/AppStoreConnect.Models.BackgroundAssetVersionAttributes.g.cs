
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetVersionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platforms")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>? Platforms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BackgroundAssetVersionStateJsonConverter))]
        public global::AppStoreConnect.BackgroundAssetVersionState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stateDetails")]
        public global::AppStoreConnect.BackgroundAssetVersionAttributesStateDetails? StateDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAttributes" /> class.
        /// </summary>
        /// <param name="createdDate"></param>
        /// <param name="platforms"></param>
        /// <param name="state"></param>
        /// <param name="stateDetails"></param>
        /// <param name="version"></param>
        /// <param name="locale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionAttributes(
            global::System.DateTime? createdDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.Platform>? platforms,
            global::AppStoreConnect.BackgroundAssetVersionState? state,
            global::AppStoreConnect.BackgroundAssetVersionAttributesStateDetails? stateDetails,
            string? version,
            string? locale)
        {
            this.CreatedDate = createdDate;
            this.Platforms = platforms;
            this.State = state;
            this.StateDetails = stateDetails;
            this.Version = version;
            this.Locale = locale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionAttributes" /> class.
        /// </summary>
        public BackgroundAssetVersionAttributes()
        {
        }

    }
}