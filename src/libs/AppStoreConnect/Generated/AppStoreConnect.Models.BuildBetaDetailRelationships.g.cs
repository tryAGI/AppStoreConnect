
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildBetaDetailRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.BuildBetaDetailRelationshipsBuild? Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBetaDetailRelationships(
            global::AppStoreConnect.BuildBetaDetailRelationshipsBuild? build)
        {
            this.Build = build;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailRelationships" /> class.
        /// </summary>
        public BuildBetaDetailRelationships()
        {
        }

    }
}