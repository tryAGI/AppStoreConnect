
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaBuildLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuild Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBuildLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.BetaBuildLocalizationCreateRequestDataRelationshipsBuild build)
        {
            this.Build = build ?? throw new global::System.ArgumentNullException(nameof(build));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaBuildLocalizationCreateRequestDataRelationships()
        {
        }

    }
}