
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_BD71F89954985066 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_BD71F89954985066 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_BD71F89954985066(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionsGetInstanceIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_ReviewSubmissionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7EDBE96ED2102835(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C09016F0E729A0AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_52259E9CBF6D5686(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_49B65BFC4EDC5410(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CB4B95ACCADE7D2F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_79FBFFCBF7B8D12B(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceFieldsReviewSubmissionItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableReviewSubmissionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_92C219A96D9B4EEB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20622BBE1D1DB39B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_015594EFF7828BCF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_49EE50F0B3041B73(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9E4AD1C6637D699A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9699DECE640DE6FC(options);
                }
                return null;
            }
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