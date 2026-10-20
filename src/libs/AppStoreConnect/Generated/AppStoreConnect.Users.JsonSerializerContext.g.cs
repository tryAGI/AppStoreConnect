
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C5284231F44A699D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E631E67CA18217AE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_51FC0F29CB3B67F1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E9CB497B6ADCE6B6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E8E1B0A02240AAC1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5125101B710CC327.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E7C793E5E1846C0F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1B33075B61A1485C.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[11];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_C5284231F44A699D.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_E631E67CA18217AE.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_51FC0F29CB3B67F1.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_E9CB497B6ADCE6B6.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_E8E1B0A02240AAC1.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_5125101B710CC327.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_E7C793E5E1846C0F.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_1B33075B61A1485C.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}