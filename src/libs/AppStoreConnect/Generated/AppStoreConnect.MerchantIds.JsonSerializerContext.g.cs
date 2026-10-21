
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class MerchantIdsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6633812AA3ACD297.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CD18B03582465464.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B892CA22CE2BD0EC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F3EB270BDAC1399.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D4D5EEA59A6A385.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6BECA2732F0F23B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1917C419391F2A6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D53359A4B5F5E5D6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5452DC61CE6AE192.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DF54832B00282B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8212CD2F2A377EA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B5D015925B2B6786.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_31DAB2C073FBAA98.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A06C3396F76CBF66.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ABA83D8093091881.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02CBEA2AB0AC9BA6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C8E88E231644AB4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2B68E2C5366A656.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5674CBB98EDF7BC8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C31D8F923F111FA.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly MerchantIdsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static MerchantIdsSourceGenerationContext Default => DefaultHolder.Instance;
        private MerchantIdsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}