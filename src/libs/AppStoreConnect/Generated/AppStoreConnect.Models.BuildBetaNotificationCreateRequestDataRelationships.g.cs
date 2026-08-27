
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildBetaNotificationCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuild Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaNotificationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBetaNotificationCreateRequestDataRelationships(
            global::AppStoreConnect.BuildBetaNotificationCreateRequestDataRelationshipsBuild build)
        {
            this.Build = build ?? throw new global::System.ArgumentNullException(nameof(build));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaNotificationCreateRequestDataRelationships" /> class.
        /// </summary>
        public BuildBetaNotificationCreateRequestDataRelationships()
        {
        }

    }
}