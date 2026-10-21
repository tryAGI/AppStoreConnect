
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionOfferCodesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_06428CA09E8C959B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9845BB834A5C7D03.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7836002592EBC859.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9647A1B7EE83B58E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B30E91D25A932433.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E10D4899A1869073.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FC297217EEED5ED9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2CC2A6B6BE45A9EA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7905AC7C80C925C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9F285FC0574AC2A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DD5B08F1CC63920.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E052CB20985F0E0D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_833D78B0737F60FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FE61B99886AF0C2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8CBBE8380C4DCAA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_65D3BA7638C3503B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2358FC1BDDCD430.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E78BAC2616FAA536.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F115FA7DD32BA9B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A295F4C3C6310706.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_141F5A8EB75F4FBA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D89B0487061CB02F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8E443FB09A17F5A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F85DEABCFC7FA04B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_88B2E6758A10BCA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B923A177654416C9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91C48F089FFD2FDA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5419B418CBD64D25.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionOfferCodesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionOfferCodesSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionOfferCodesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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