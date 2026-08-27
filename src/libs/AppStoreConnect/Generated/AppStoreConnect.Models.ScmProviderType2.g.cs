
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScmProviderType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ScmProviderTypeKindJsonConverter))]
        public global::AppStoreConnect.ScmProviderTypeKind? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOnPremise")]
        public bool? IsOnPremise { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderType2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="displayName"></param>
        /// <param name="isOnPremise"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmProviderType2(
            global::AppStoreConnect.ScmProviderTypeKind? kind,
            string? displayName,
            bool? isOnPremise)
        {
            this.Kind = kind;
            this.DisplayName = displayName;
            this.IsOnPremise = isOnPremise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderType2" /> class.
        /// </summary>
        public ScmProviderType2()
        {
        }

    }
}