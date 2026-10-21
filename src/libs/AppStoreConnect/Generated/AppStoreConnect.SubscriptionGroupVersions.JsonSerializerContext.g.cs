
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionGroupVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24EC6EC03EA3576F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45540812E82665DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_109E242DED1F257B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30A0173AB978E8B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A235D6156F420405.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E505AF120F047D7E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57BD86282174EAE6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ACEB07934750FE69.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5E095A10E087DDD9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_13EFA7896FC9D642.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D986B083A098460B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3820AD3E36915651.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionGroupVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionGroupVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionGroupVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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