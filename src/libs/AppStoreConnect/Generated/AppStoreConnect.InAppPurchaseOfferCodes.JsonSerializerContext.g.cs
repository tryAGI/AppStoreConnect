
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InAppPurchaseOfferCodesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InAppPurchaseOfferCodesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_2DF7194A51C07E52.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_624E545626345B89.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FA22A6324F64A380.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A7F6D47573A63BCF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F641E634287E55B9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C42BB1DB5F078A75.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8D9F96CBE10BC224.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_015E7FED775248CD.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BC8C5361C373AE05.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9D67CCF430949D94.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[13];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_2DF7194A51C07E52.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_624E545626345B89.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_FA22A6324F64A380.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_A7F6D47573A63BCF.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_F641E634287E55B9.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_C42BB1DB5F078A75.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_8D9F96CBE10BC224.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_015E7FED775248CD.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_BC8C5361C373AE05.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_9D67CCF430949D94.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}