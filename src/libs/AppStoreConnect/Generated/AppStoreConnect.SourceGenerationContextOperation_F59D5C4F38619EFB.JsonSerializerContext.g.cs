
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_F59D5C4F38619EFB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E523330472A111D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_73245CF64883B70F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_77A3EA5947EE91DC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_795412F5DEE80DCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_19F4C0ABC60716E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DFB3BD2263AB43B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_39E75B66A681BEEF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F63DF0647A0B4A67.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF22451B36EAE26A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_F59D5C4F38619EFB Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_F59D5C4F38619EFB Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_F59D5C4F38619EFB(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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