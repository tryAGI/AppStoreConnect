
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class EndUserLicenseAgreementsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_38D9799E50814BBC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_248F853288DD08B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4EDEB68C626DED9F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CEEF47EC9B6FF08.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1A9B550C0D169B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_728B3E8BAD5D31C8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D4266433F5ADBE13.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EEAA1F1A8934BE88.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5FD181A034AC7A5D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_385AD0638BFF97AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B4F419050AF10BF6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D20C060B79DC0900.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly EndUserLicenseAgreementsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static EndUserLicenseAgreementsSourceGenerationContext Default => DefaultHolder.Instance;
        private EndUserLicenseAgreementsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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