
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_45360193DC7A249E
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

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