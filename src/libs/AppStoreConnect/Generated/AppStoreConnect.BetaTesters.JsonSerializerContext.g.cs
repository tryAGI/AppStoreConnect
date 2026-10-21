
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaTestersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57BE895C93D51A0F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B4DB352D83D88517.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2107250EEAC8C9ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E2A2BB580C52B6F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CAA29E7A882B7E4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EC8EC25B177F646.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C8C15AF75D0685F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B7BE871F99DE5C91.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AD0806BD8FF86C18.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6F2097A7FD7800E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C5EEBE9AE5990A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_100F5CDFFA646D33.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9F8667443194D64.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AF075F0112219822.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_488A5D737E196788.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FAAF18B177E6DB8D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_86FB332364BD06D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6F8B8275E607810.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CBAF32AB448A7A38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B8153711591CA788.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70CF3E9F15D57FE3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AA03D23AF79EAE56.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D1342F7501B2708.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E9AEDDCED3657A17.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98B22D18ED61532C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_23D63F76B56403A0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8BD2DC2BFDE70838.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB660BDE676C8547.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9346D42387BA7634.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57B4BCF87A17C047.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2787439847BD1F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A77A5C67E6109EC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6965630EAC37BAAE.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaTestersSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaTestersSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaTestersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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