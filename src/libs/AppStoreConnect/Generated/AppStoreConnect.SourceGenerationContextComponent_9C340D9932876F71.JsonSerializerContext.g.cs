
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9C340D9932876F71
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6F56DD464FB198A2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76F894C37BACBA43.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7FB102C74A9083DC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_854566A3BFC08432.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A33EEFBFB9D9F2BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1322DCD7AA912CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DF727927E08FE852.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem4JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem4JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem4))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem42_3.Create_IncludedItem42_3(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem4?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem42_3.Create_NullableIncludedItem42_3(options);
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