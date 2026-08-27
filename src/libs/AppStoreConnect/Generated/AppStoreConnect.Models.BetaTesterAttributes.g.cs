
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BetaInviteTypeJsonConverter))]
        public global::AppStoreConnect.BetaInviteType? InviteType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BetaTesterStateJsonConverter))]
        public global::AppStoreConnect.BetaTesterState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appDevices")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterAttributesAppDevice>? AppDevices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterAttributes" /> class.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="inviteType"></param>
        /// <param name="state"></param>
        /// <param name="appDevices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterAttributes(
            string? firstName,
            string? lastName,
            string? email,
            global::AppStoreConnect.BetaInviteType? inviteType,
            global::AppStoreConnect.BetaTesterState? state,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterAttributesAppDevice>? appDevices)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.InviteType = inviteType;
            this.State = state;
            this.AppDevices = appDevices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterAttributes" /> class.
        /// </summary>
        public BetaTesterAttributes()
        {
        }

    }
}