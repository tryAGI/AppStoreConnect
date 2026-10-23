
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EB0224DF68CFE946
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4CD85D26125A6D7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C8E3BE5F565B22C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76CE20A45CB719CD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7929853FBC71C2EB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9DCB3A53FBF7F371.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A098FEDBCDF8CE5E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C3214EC78D47120F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F02A412AF98F7966.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F482CEC150688BA3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5E234E3C99CB66D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9EB844A75ACFD31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB2419DD4F6DBDC6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.Attributes2JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.Attributes2JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.Attributes2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0180.Create_Attributes22(options);
                }
                if (type == typeof(global::AppStoreConnect.Attributes2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0574.Create_NullableAttributes22(options);
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