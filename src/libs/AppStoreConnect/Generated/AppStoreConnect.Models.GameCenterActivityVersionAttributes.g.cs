
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterActivityVersionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter))]
        public global::AppStoreConnect.GameCenterVersionState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackUrl")]
        public string? FallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionAttributes" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="state"></param>
        /// <param name="fallbackUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityVersionAttributes(
            int? version,
            global::AppStoreConnect.GameCenterVersionState? state,
            string? fallbackUrl)
        {
            this.Version = version;
            this.State = state;
            this.FallbackUrl = fallbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionAttributes" /> class.
        /// </summary>
        public GameCenterActivityVersionAttributes()
        {
        }

    }
}