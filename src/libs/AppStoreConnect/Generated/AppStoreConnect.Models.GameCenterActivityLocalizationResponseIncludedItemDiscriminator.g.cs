
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityLocalizationResponseIncludedItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityLocalizationResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityLocalizationResponseIncludedItemDiscriminator(
            global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityLocalizationResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        public GameCenterActivityLocalizationResponseIncludedItemDiscriminator()
        {
        }

    }
}