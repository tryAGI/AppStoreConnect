
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class RetentionMessagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_65D4D0C54562C158.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_38E58F3491D1D046.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28C486410056DFA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B30A38249DFBB4B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A720BA1CBEABE4B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BEDF35C7194FAE38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D613615D0B44347D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E800B71AD74C9411.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EFA17F4A66CEB86.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F919044BAA3EA65B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_60CC790240E5C3E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6EBD1ED3FC9CD03.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D83C8903A96DE39C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E7739C5CFFEA02B3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A663EDB52EAF8E5D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A0D6385CB48E09F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A1C27259C77A36B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D24DB8E0B352C460.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BF528F57E52E44B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_42197F996735B6BD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_47E411CD87E7D73C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_04D710E2FC8A3D10.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_69088BBC1012D238.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5F5BD88685178C2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_864F5C1423AA4BA8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E3AE9476FCE048C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99A92436E7181144.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D251B3353EFD5943.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01E43571FA3201D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BBC6E9311182F787.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E1ECBAD9E04672E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5527EE865499704.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98458378284F82E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AFEEF5E5E1C7DFD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA04D4F34B938CE0.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly RetentionMessagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static RetentionMessagesSourceGenerationContext Default => DefaultHolder.Instance;
        private RetentionMessagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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