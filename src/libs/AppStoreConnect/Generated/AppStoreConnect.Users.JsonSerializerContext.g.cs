
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB79553A67820AB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92EDDAEA0B049259.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C2285DB7B1FD496.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_028F24FC41C0275F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED399BEED40B783B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0692E4CB7C7F3DF8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDD369D19C7C9EA8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E414AE3E07F2405D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_354AAEC19312F7CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0DCDA3C127262135.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2720A4B409C3FEB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80192A4DEDC0FF7D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_404219D1F4926CEE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_77D0087E7CA99696.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2107250EEAC8C9ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4E5F81352F23F51A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB5F83901D04B59C.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly UsersSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static UsersSourceGenerationContext Default => DefaultHolder.Instance;
        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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