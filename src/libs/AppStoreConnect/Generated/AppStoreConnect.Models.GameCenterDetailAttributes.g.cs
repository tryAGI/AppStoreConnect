
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterDetailAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arcadeEnabled")]
        public bool? ArcadeEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeEnabled")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ChallengeEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailAttributes" /> class.
        /// </summary>
        /// <param name="arcadeEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterDetailAttributes(
            bool? arcadeEnabled)
        {
            this.ArcadeEnabled = arcadeEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailAttributes" /> class.
        /// </summary>
        public GameCenterDetailAttributes()
        {
        }

    }
}