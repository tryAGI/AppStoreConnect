
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterInvitationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaTester")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.BetaTesterInvitationCreateRequestDataRelationshipsBetaTester? BetaTester { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaTesterInvitationCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterInvitationCreateRequestDataRelationships(
            global::AppStoreConnect.BetaTesterInvitationCreateRequestDataRelationshipsApp app)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaTesterInvitationCreateRequestDataRelationships()
        {
        }

    }
}