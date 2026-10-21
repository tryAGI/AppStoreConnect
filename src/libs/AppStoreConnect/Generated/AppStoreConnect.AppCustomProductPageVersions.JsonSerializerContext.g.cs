
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppCustomProductPageVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F791AC46A1F387C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2CE86CC1F1A096A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7FDBE204B08E413E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E85BBDEB1E5682D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC05556FAB8009F9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4B251E589884EACB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70242F9BAC1F3988.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_50E3EDF230F1A356.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F4994877D225F160.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D5F4558DB7D56B3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_482A8AF9AA9E46E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_87A6B41015A4AD18.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6924D5CE9345BFBB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E87888CD9E9F3FD8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_437EDA7376779301.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17597F2C2CA0784D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1BAE78C4AD3A0141.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppCustomProductPageVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppCustomProductPageVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppCustomProductPageVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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