
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_0F582281B2BE44A1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02BABCEBBD06ECCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_08A22A439351122B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0AB27909AA595163.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3B4B606BA9382B3A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_48AD61B894796A76.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4D4B6AC62B040D07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57B5C1566DE51BDB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7AAF8B11B9AB449D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_982B14E9AF9AAD2D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A131B389C9489744.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BD3D79BE45D11A6F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1CE4B89C460AB47.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EE44A1E38642F902.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F13C1EADE701EDC1.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_0F582281B2BE44A1 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_0F582281B2BE44A1 Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_0F582281B2BE44A1(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_SubscriptionRelationships.Create_SubscriptionRelationships(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}