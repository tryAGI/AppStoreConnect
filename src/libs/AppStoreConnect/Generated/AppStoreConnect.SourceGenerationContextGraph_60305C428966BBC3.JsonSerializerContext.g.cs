
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_60305C428966BBC3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_60305C428966BBC3 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_60305C428966BBC3(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FC90884535C65199(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6224BF767060F79F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_522388CFF93682D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_046DDBAD144F90C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_01846612D98C5AC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DF4CE294A928031B(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedFieldsCustomerReview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedFilterTerritoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_77B83845E357D206(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E247EACD7B4D1B55(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_42E97DCCF0174938(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_66ACF7A73D34BA55(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AE683C836FC359CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3C488C109EC9C474(options);
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