
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C2CAF8C92ED0ADE
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2579F155FB1DB609.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_931D0A4FE5897D26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_95DE323E5EFC23B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2DEB46B39ED4572.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC37D508BF00C275.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B55B99E8A5E7F369.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB36BF3A2A0FDBF1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2D96BAD9F15EA80.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.AppInfoAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AppInfoAttributes.Create_AppInfoAttributes(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}