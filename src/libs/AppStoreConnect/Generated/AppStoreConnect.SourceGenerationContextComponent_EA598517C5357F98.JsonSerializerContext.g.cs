
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EA598517C5357F98
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0A15B41EB5A0AA4E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4E250B0969AC5EB5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5149449EDF5D5EB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_611A1A46CC83F73D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A7E71E47DB549C63.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BA53B1BE21F8B436.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5963CC99276F3D5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C9A2DCD8811AFC02.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DDC2A5C4AAB428FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E8D837493C6E7E1B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EE4FC49114AEA692.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDEBC2604D2E4227.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.AttributesJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.AttributesJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0180.Create_Attributes2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.Attributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0574.Create_NullableAttributes2_3(options);
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