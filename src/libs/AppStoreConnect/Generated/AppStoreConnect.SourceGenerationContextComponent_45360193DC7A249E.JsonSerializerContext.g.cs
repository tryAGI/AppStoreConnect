
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_45360193DC7A249E : global::System.Text.Json.Serialization.JsonSerializerContext
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
            internal static readonly SourceGenerationContextComponent_45360193DC7A249E Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_45360193DC7A249E Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_45360193DC7A249E(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease), static () => new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?), static () => new global::AppStoreConnect.JsonConverters.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2.Create_GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2.Create_NullableGameCenterDetailsLeaderboardSetReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease2(options);
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