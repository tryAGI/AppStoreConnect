
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_52008F4D51B63BA9
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18C33BD6FECB37EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1EA8A8566795F557.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B1153695911883A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72E236AC69CC0FEF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_784FD24FA5FA3E90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85538343EC105B3B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97D140A7AE1AA859.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C794C710692D3CC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3C3EF4411CC2F7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D89C92F5F6C7551D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DC4C2D977DC8F96A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E4470052301C060F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5EC5719757D9805.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFDF7F25215C11BA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F55472936DF23856.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem103JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem103JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem103))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0467.Create_IncludedItem1032(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem103?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0708.Create_NullableIncludedItem1032(options);
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