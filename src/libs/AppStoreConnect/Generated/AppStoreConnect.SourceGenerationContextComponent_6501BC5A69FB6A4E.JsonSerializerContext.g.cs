
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6501BC5A69FB6A4E
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02DDD8522424A084.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0868E8DB075C5D05.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_35A1DE2E87CDDBE7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_595179A08F051FF1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B81BAB97CE84F9E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62FC50089768F020.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8125841DDD09F437.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_87E9B8D02DD7F6AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AAAB2170A1C08AD4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B4A436D81C5ACC35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C86F6A55DBB6848E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem147JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem147JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem147))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem1472.Create_IncludedItem1472(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem147?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem1472.Create_NullableIncludedItem1472(options);
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