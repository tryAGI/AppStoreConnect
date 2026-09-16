
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclaration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationType), TypeInfoPropertyName = "AccessibilityDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DeviceFamily), TypeInfoPropertyName = "DeviceFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState), TypeInfoPropertyName = "AccessibilityDeclarationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType), TypeInfoPropertyName = "AccessibilityDeclarationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType), TypeInfoPropertyName = "AccessibilityDeclarationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration), TypeInfoPropertyName = "AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationType?), TypeInfoPropertyName = "NullableAccessibilityDeclarationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DeviceFamily?), TypeInfoPropertyName = "NullableDeviceFamily2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState?), TypeInfoPropertyName = "NullableAccessibilityDeclarationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType?), TypeInfoPropertyName = "NullableAccessibilityDeclarationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAccessibilityDeclarationCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType?), TypeInfoPropertyName = "NullableAccessibilityDeclarationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration?), TypeInfoPropertyName = "NullableAccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration>))]
    internal sealed partial class AccessibilityDeclarationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessibilityDeclarationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccessibilityDeclarationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccessibilityDeclarationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
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
                    typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily)

                    || typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.DeviceFamily?))
                {
                    return new global::AppStoreConnect.JsonConverters.DeviceFamilyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
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
                    0 => new AccessibilityDeclarationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}