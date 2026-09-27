
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewCategorieSectionUnit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSectionUnit" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="displayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewCategorieSectionUnit(
            string? identifier,
            string? displayName)
        {
            this.Identifier = identifier;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorieSectionUnit" /> class.
        /// </summary>
        public XcodeOverviewCategorieSectionUnit()
        {
        }

    }
}