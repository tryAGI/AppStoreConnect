
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildBetaDetailAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoNotifyEnabled")]
        public bool? AutoNotifyEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalBuildState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InternalBetaStateJsonConverter))]
        public global::AppStoreConnect.InternalBetaState? InternalBuildState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalBuildState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ExternalBetaStateJsonConverter))]
        public global::AppStoreConnect.ExternalBetaState? ExternalBuildState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailAttributes" /> class.
        /// </summary>
        /// <param name="autoNotifyEnabled"></param>
        /// <param name="internalBuildState"></param>
        /// <param name="externalBuildState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBetaDetailAttributes(
            bool? autoNotifyEnabled,
            global::AppStoreConnect.InternalBetaState? internalBuildState,
            global::AppStoreConnect.ExternalBetaState? externalBuildState)
        {
            this.AutoNotifyEnabled = autoNotifyEnabled;
            this.InternalBuildState = internalBuildState;
            this.ExternalBuildState = externalBuildState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailAttributes" /> class.
        /// </summary>
        public BuildBetaDetailAttributes()
        {
        }

    }
}