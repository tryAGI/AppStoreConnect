
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0A2AFEF403236B97 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0A2AFEF403236B97 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0A2AFEF403236B97(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_14E434C603B21E51(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E78BEEA546CCDE09(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_26DB873E1F2CCE1B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_76AEE9D45001A795(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DCA172817EC115F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C48DB22A35B32B23(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_AAEF88EED6A29792(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_05C0D73169059656(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_178C1D6A483374BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6DE06297A49C09E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FA041B80B415ECC6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F45F609F6E18A2FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EB5C8B75C204C595(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2AC2EDA3E9E8320E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4710A38AED6601C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CC44DB4AE3D1617E(options);
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