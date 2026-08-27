
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProfileAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter))]
        public global::AppStoreConnect.BundleIdPlatform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ProfileAttributesProfileTypeJsonConverter))]
        public global::AppStoreConnect.ProfileAttributesProfileType? ProfileType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ProfileAttributesProfileStateJsonConverter))]
        public global::AppStoreConnect.ProfileAttributesProfileState? ProfileState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileContent")]
        public string? ProfileContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="profileType"></param>
        /// <param name="profileState"></param>
        /// <param name="profileContent"></param>
        /// <param name="uuid"></param>
        /// <param name="createdDate"></param>
        /// <param name="expirationDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProfileAttributes(
            string? name,
            global::AppStoreConnect.BundleIdPlatform? platform,
            global::AppStoreConnect.ProfileAttributesProfileType? profileType,
            global::AppStoreConnect.ProfileAttributesProfileState? profileState,
            string? profileContent,
            string? uuid,
            global::System.DateTime? createdDate,
            global::System.DateTime? expirationDate)
        {
            this.Name = name;
            this.Platform = platform;
            this.ProfileType = profileType;
            this.ProfileState = profileState;
            this.ProfileContent = profileContent;
            this.Uuid = uuid;
            this.CreatedDate = createdDate;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAttributes" /> class.
        /// </summary>
        public ProfileAttributes()
        {
        }

    }
}