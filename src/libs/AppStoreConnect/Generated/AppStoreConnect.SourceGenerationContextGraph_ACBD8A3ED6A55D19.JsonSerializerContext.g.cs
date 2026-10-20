
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_ACBD8A3ED6A55D19 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_ACBD8A3ED6A55D19 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_ACBD8A3ED6A55D19(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocumentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocumentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F12FBA52C1262EF6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2181FFBC24624EFA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_2D9B9D0D0D0D8749(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ACAE6C25E4EFCDF7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_314835728F9C3CFD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8DF0531A24B14DD2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0EAD37AB972C77B0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4A8045602479A258(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BBD442F3AE203D60(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20C6EFCCC7CC3F1E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C696846BE5899022(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1F4CF10A50B18E8C(options);
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