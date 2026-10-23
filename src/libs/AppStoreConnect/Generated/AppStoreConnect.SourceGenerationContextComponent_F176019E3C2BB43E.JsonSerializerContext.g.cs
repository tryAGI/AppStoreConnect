
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F176019E3C2BB43E
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02DDD8522424A084.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_161EFBA73DF31BDE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2CA803D7BB1666DC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43AFBBA8C1044645.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B1153695911883A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6F56DD464FB198A2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_75FC45B828ED6290.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_78745B4297627C5B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82EBF41229562BB4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_854566A3BFC08432.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93F8C73AD90D40E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FCC613CE391A98B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D0041F9A51F29D01.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6B1F6F57126ADC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DC090C8C279EAD05.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E72640CD68F226E5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem156JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem156JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem156))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0470.Create_IncludedItem1562(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem156?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0711.Create_NullableIncludedItem1562(options);
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