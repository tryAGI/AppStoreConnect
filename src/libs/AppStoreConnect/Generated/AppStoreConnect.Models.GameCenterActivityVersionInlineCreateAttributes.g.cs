
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityVersionInlineCreateAttributes
    {
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
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="fallbackUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityVersionInlineCreateAttributes(
            string? fallbackUrl)
        {
            this.FallbackUrl = fallbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionInlineCreateAttributes" /> class.
        /// </summary>
        public GameCenterActivityVersionInlineCreateAttributes()
        {
        }

    }
}