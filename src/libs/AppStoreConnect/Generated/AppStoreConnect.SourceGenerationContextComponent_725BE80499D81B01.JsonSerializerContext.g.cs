
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_725BE80499D81B01
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30D43DE49C504CB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_33397861D299F491.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4143C7EB9AD10C6D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_583460E8FA358072.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_86DB682852575CFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EC74D48BBEE88C8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2BD5975F2D10305.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EBA66B72564C096B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F97B02E426E69887.MetadataScope,
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
                if (type == typeof(global::AppStoreConnect.GameCenterGroupRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0354.Create_GameCenterGroupRelationships(options);
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