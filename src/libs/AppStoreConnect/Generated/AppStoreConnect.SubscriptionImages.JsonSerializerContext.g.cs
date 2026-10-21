
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_928623E7F083B081.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_422595742F39885B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2D9EAB43F06E5FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80A1F105530C08A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2BD80FDE4594780C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_201A4879F9969DB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1573BCF88A2393A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AAD1C7C28386ACB4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5C921029342B9E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DFBC258FF53A2CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EF209124032BD86.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97E0BE775381D2AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57FE1F4BA5D5563D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BEB27840599C51CF.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionImagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionImagesSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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