
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterActivityVersionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterActivityVersionCreateRequestDataRelationshipsActivity Activity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="activity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityVersionCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterActivityVersionCreateRequestDataRelationshipsActivity activity)
        {
            this.Activity = activity ?? throw new global::System.ArgumentNullException(nameof(activity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterActivityVersionCreateRequestDataRelationships()
        {
        }

    }
}