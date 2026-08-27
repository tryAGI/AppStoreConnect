
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionPhasedReleaseCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phasedReleaseState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PhasedReleaseStateJsonConverter))]
        public global::AppStoreConnect.PhasedReleaseState? PhasedReleaseState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="phasedReleaseState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionPhasedReleaseCreateRequestDataAttributes(
            global::AppStoreConnect.PhasedReleaseState? phasedReleaseState)
        {
            this.PhasedReleaseState = phasedReleaseState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionPhasedReleaseCreateRequestDataAttributes()
        {
        }

    }
}