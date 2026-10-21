
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaAppReviewSubmissionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_901E9E1771803BA5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_08BD7855B9414890.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA492D7BA36FB725.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_89FB542424709264.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2499C0E9BC1FD4C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9EC450C5640ABDD1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A1EE62D56238B7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3A9E4DEFEB45BD56.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8A8E781894E9C53.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2DFF000F6433E5D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9A789997A9B279C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93F2CDB322B98FFB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_52400D8DE8DF3572.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2006E8556125E6D7.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaAppReviewSubmissionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaAppReviewSubmissionsSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaAppReviewSubmissionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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