
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionPricePointsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18ADCADA377569DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B057E7D2B5A67AAB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E7504938FA483C7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2FB46E5DF688ACB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27D0D132CCB4AD4D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A7ADBFABE7A0F185.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8FD567056A447AD8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E88FBF8CBE791994.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CEBDED1955F8E0B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB5D18808B8F36B7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_808D192D1272CCF6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BD73DD6D537B73AB.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionPricePointsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionPricePointsSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionPricePointsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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