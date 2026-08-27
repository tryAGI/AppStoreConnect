
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppScreenshotSetAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshotDisplayType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ScreenshotDisplayTypeJsonConverter))]
        public global::AppStoreConnect.ScreenshotDisplayType? ScreenshotDisplayType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetAttributes" /> class.
        /// </summary>
        /// <param name="screenshotDisplayType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppScreenshotSetAttributes(
            global::AppStoreConnect.ScreenshotDisplayType? screenshotDisplayType)
        {
            this.ScreenshotDisplayType = screenshotDisplayType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppScreenshotSetAttributes" /> class.
        /// </summary>
        public AppScreenshotSetAttributes()
        {
        }

    }
}