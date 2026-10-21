
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_63006B2FB82B1891
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2BE382285CAF52C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D1EF38E107DF4EA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_354FC44838375CC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C5D61CD071FA812.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F8AC76BF5D210B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43BEA75C9395026A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4ABFD619C80D5BDA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_601688309183DB6D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80E15D5AAF8B7E7B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C9F80B2BCD3E0BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F2CBDF33F297050.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F45465721BB980C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2ED3CFE0482357B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ABDFBE269E56D08F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B059ECC2432AA97F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B787D70E5530A436.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DD45FCC3AC903F84.MetadataScope,
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
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_ReviewSubmissionItemCreateRequestDataRelationships.Create_ReviewSubmissionItemCreateRequestDataRelationships(options);
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