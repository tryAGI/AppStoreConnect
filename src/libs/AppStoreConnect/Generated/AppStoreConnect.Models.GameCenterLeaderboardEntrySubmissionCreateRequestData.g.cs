
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardEntrySubmissionCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardEntrySubmissionCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardEntrySubmissionCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardEntrySubmissionCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardEntrySubmissionCreateRequestData(
            global::AppStoreConnect.GameCenterLeaderboardEntrySubmissionCreateRequestDataAttributes attributes,
            global::AppStoreConnect.GameCenterLeaderboardEntrySubmissionCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardEntrySubmissionCreateRequestData" /> class.
        /// </summary>
        public GameCenterLeaderboardEntrySubmissionCreateRequestData()
        {
        }

    }
}