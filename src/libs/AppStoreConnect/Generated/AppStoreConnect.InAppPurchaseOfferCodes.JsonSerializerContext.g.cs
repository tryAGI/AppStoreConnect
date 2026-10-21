
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InAppPurchaseOfferCodesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FD4CCD4A817A011.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F47B1C984E9D188C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B12D2D84330A550E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_46D6FB01B0AC4228.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A3700B4152DC319E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C6915BD0C414EE5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E5EACE527340D0F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2098AACECFF7C0C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8CA789262A938A19.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_846497816E3BBA98.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2940F4907BD44E30.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3046516FE0D6D069.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70DFC8E4B343F90D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9AF794B8E1A84D52.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_807E1783156B9775.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2FAD23EDC5D1EDA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F8646468D9CD11C6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7D8E7D42E1178E59.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA175528B622C2D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C81236EF09490615.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EF689F2F39D464C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_578B52BC1329E161.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C19EDA424314BE2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_453F73F1F69968A8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_52452972F96EB7FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_048016E1F66BE536.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_535BF3366B081CAB.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InAppPurchaseOfferCodesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InAppPurchaseOfferCodesSourceGenerationContext Default => DefaultHolder.Instance;
        private InAppPurchaseOfferCodesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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