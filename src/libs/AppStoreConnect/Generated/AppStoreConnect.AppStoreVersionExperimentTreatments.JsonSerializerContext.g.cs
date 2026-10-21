
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppStoreVersionExperimentTreatmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0646681CD4027B3A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_105E63A61ACFD68E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97F22F2C2659A56A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8ACA8FCB104D2CC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_146692E3FA0454E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EBE04CD40E2CCCFA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3A66B5C3BDCEA137.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1C9CCC08320C6F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B88BF6F835E80F0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BA1392C053C52EF7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D9D9B5694397185.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_346425D7245BBD5B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9E950DA1E4362278.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4011A0C3F0D0AFC3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A096E367AB5CD36.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9ED3847D8804BDDD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1CC2EEFCD982397F.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppStoreVersionExperimentTreatmentsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppStoreVersionExperimentTreatmentsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppStoreVersionExperimentTreatmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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