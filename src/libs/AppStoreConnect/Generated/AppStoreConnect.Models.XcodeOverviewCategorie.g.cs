
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewCategorie
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorieSection>? Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorie" /> class.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="displayName"></param>
        /// <param name="sections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewCategorie(
            string? identifier,
            string? displayName,
            global::System.Collections.Generic.IList<global::AppStoreConnect.XcodeOverviewCategorieSection>? sections)
        {
            this.Identifier = identifier;
            this.DisplayName = displayName;
            this.Sections = sections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewCategorie" /> class.
        /// </summary>
        public XcodeOverviewCategorie()
        {
        }

    }
}