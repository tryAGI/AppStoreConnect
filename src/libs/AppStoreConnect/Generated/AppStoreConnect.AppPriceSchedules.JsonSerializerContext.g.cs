
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceSchedulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppPriceSchedulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppPriceSchedulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_B1551711A7F502A3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DF52A1FBC4849547.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E5F3F47514E43872.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_765D2D1B79C5CE91.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F47132DEA5B7106A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_36B3C05DF981DE5A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F7A6EBE852AE9C32.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C9B427885CB8EF46.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_666A32D1F2268FE3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BC7D9F99C18F3AA5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9310EAF35DE8F141.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[14];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_B1551711A7F502A3.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_DF52A1FBC4849547.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_E5F3F47514E43872.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_765D2D1B79C5CE91.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_F47132DEA5B7106A.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_36B3C05DF981DE5A.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_F7A6EBE852AE9C32.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_C9B427885CB8EF46.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_666A32D1F2268FE3.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_BC7D9F99C18F3AA5.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_9310EAF35DE8F141.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}