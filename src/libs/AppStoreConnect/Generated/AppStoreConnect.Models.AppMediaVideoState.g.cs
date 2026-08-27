
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppMediaVideoState
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>? Errors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>? Warnings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppMediaVideoStateStateJsonConverter))]
        public global::AppStoreConnect.AppMediaVideoStateState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMediaVideoState" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="warnings"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppMediaVideoState(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>? errors,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>? warnings,
            global::AppStoreConnect.AppMediaVideoStateState? state)
        {
            this.Errors = errors;
            this.Warnings = warnings;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMediaVideoState" /> class.
        /// </summary>
        public AppMediaVideoState()
        {
        }

    }
}