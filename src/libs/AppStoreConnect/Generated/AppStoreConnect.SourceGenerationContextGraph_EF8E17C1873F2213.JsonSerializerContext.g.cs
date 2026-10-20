
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_EF8E17C1873F2213 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_EF8E17C1873F2213 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_EF8E17C1873F2213(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsReviewSubmissionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsReviewSubmissionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_99A600B4BB3DC9C0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5600FE2D86CE031B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_10772B02F53975A8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E4B082F8D69841E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5D3B098E411FF020(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_28234D3C77C44BAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_74F7CD2B15B4314D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_36DB8712FC5E30EC(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsReviewSubmissionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F422606891A34EE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_057F636AFEBF9536(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_230F54BD0FF07CD9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DDE0BEDE5148AFFA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_243B0C663025859B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9C57B8078B04E39B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B7570F0585ABA666(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CA59308872694417(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}