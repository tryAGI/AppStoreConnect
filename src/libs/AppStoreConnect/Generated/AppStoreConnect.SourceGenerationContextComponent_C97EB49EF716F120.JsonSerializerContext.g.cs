
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C97EB49EF716F120
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18C33BD6FECB37EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72E236AC69CC0FEF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85538343EC105B3B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B792699F4D0BE8D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C164DE2ED11A4E56.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C794C710692D3CC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3C3EF4411CC2F7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5EC5719757D9805.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E63345E0CFC7F8BB.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem131JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem131JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem131))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0469.Create_IncludedItem1312(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem131?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0710.Create_NullableIncludedItem1312(options);
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