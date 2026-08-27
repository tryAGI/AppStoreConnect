
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterEnabledVersionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionString")]
        public string? VersionString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconAsset")]
        public global::AppStoreConnect.ImageAsset? IconAsset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterEnabledVersionAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="versionString"></param>
        /// <param name="iconAsset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterEnabledVersionAttributes(
            global::AppStoreConnect.Platform? platform,
            string? versionString,
            global::AppStoreConnect.ImageAsset? iconAsset)
        {
            this.Platform = platform;
            this.VersionString = versionString;
            this.IconAsset = iconAsset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterEnabledVersionAttributes" /> class.
        /// </summary>
        public GameCenterEnabledVersionAttributes()
        {
        }

    }
}