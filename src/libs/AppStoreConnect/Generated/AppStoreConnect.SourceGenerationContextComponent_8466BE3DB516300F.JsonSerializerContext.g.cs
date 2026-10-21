
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8466BE3DB516300F
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02D45C6392B47A98.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_22AA0667D9E480EC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_39A219E04E1AB883.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_411AD73448DC7972.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5352CC39554F49A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_601897949E2804EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62FC50089768F020.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DFC304D172DF5A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FB02CCDE70B20A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B1F3610CB842075C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B6199BF8F822535A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3FA1DF972E084B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E72640CD68F226E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F2A0F6134DC3F359.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem179JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem179JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem179))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem1792.Create_IncludedItem1792(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem179?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem1792.Create_NullableIncludedItem1792(options);
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