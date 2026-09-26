
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PerformanceOverviewAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceOverviewAttributes" /> class.
        /// </summary>
        /// <param name="deviceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerformanceOverviewAttributes(
            string? deviceType)
        {
            this.DeviceType = deviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceOverviewAttributes" /> class.
        /// </summary>
        public PerformanceOverviewAttributes()
        {
        }

    }
}