
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_17BC10B45B956763 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_17BC10B45B956763 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_17BC10B45B956763(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoUpdateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoUpdateRequestDataType2(options);
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