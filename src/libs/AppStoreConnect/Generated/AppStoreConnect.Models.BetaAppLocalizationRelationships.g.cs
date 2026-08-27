
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.BetaAppLocalizationRelationshipsApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppLocalizationRelationships(
            global::AppStoreConnect.BetaAppLocalizationRelationshipsApp? app)
        {
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppLocalizationRelationships" /> class.
        /// </summary>
        public BetaAppLocalizationRelationships()
        {
        }

    }
}