
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppEventLocalizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppEventLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_4FF5736C6C0CD47B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CB7C71A8405E0733.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D1000F3F5E3B5160.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0E73B3E38C3B65EC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4FFD6A498004C4B5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FC1661A02654C782.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D4AD4406A895BDBA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_867182C2F10337B7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8CA26431ECB4FDC9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4A563439E9E3E402.AddConverters(options);
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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_4FF5736C6C0CD47B.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_CB7C71A8405E0733.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_D1000F3F5E3B5160.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_0E73B3E38C3B65EC.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_4FFD6A498004C4B5.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_FC1661A02654C782.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_D4AD4406A895BDBA.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_867182C2F10337B7.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_8CA26431ECB4FDC9.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_4A563439E9E3E402.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}