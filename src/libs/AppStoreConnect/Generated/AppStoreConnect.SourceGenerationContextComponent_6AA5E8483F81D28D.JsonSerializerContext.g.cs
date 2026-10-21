
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_6AA5E8483F81D28D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_6AA5E8483F81D28D Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_6AA5E8483F81D28D Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_6AA5E8483F81D28D(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction), static () => new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildActionJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction?), static () => new global::AppStoreConnect.JsonConverters.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildActionNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2.Create_CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableCiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2.Create_NullableCiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction2(options);
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