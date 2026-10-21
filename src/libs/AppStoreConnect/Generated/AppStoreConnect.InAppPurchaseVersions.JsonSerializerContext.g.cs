
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InAppPurchaseVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A5B63A2F27A60F8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C33B9DDEEB1049E0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC0405E4E2612CFA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0594213337129F3E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_142EE47945E2941D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6E527B4007544BA3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2C99C63664ADDB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E11078703F4A44AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE1BF81D80F95200.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1BD9906814D8478.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA023C29E5CB76D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C4E78676DC26AD15.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8E21F20A2602AB27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CBE545F2343BEAB9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76C872BB36957FFF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8647F2CC34A90945.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B96658EEB65423E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_38E452B26BCBBEFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5879082DB40DFBCF.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InAppPurchaseVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InAppPurchaseVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private InAppPurchaseVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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