
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class RetentionMessageVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F96282E0FB252C5B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2356B8933F9D3851.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9DD9817C58F025B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02EC0EC757B4AA96.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B4D1734C4AA68407.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E889D0F24551A3FB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC622136FAFB6403.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70D610760FC7C05B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C949C3585508FB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2B680FB11AFA2E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1FAFC2FA931E0FE8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C7B9CE809AACD76.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_38C7FAECC6368523.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C133C05496FFD5C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_56739B789A388DC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F90EDC59B6AA39D7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4077502DE71EDBBB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B32C32E06160A2C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21B34D7F9427592E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93DBD5E1D30E092F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E21A6A63866AFDB0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DD1F9403BA692CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8667587D804E3C42.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C21EFD707146562C.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly RetentionMessageVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static RetentionMessageVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private RetentionMessageVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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