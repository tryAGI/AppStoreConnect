
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class UserInvitationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_490C8337F846F669.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_670627DD15591C8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_163EF8EF21AAAAB2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_349834CA75FABDFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E48BF40C0357253D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DA01FE6ADFC13DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8A00FE2989D739AB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_64FF423569FB8501.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_167B3BD747C7C37A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CDCF611E4BA496AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_761DC6414B48D48B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_727305C1F542222E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2107250EEAC8C9ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_209F69420C4E07E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8E177A0FF8D8EDFB.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly UserInvitationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static UserInvitationsSourceGenerationContext Default => DefaultHolder.Instance;
        private UserInvitationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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