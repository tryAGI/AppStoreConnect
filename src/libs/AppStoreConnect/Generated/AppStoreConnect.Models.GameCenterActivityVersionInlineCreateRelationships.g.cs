
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityVersionInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivity? Activity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="activity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityVersionInlineCreateRelationships(
            global::AppStoreConnect.GameCenterActivityVersionInlineCreateRelationshipsActivity? activity)
        {
            this.Activity = activity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionInlineCreateRelationships" /> class.
        /// </summary>
        public GameCenterActivityVersionInlineCreateRelationships()
        {
        }

    }
}