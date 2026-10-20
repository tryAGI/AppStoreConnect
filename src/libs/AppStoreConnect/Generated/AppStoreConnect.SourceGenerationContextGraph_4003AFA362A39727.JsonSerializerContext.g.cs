
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_4003AFA362A39727 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_4003AFA362A39727 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_4003AFA362A39727(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppEncryptionDeclarationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_97C4A11CB4F9EED8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3326812AA1A5D908(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F5C8C85D3D8FADD2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ED356F5DE5C1ED9F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_66486404CF5BA374(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppEncryptionDeclarationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1B03A4FD0A135D95(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FE9177477F9DEA53(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0474DDD0C6E3ADCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BD85E963287D9421(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE9D0C041C8010AF(options);
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