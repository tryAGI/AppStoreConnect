#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryPlacementImageRelationships : global::System.IEquatable<AppAssetLibraryPlacementImageRelationships>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? AppAssetLibraryPlacementCommonRelationships { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? AppAssetLibraryPlacementCommonRelationships { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementCommonRelationships))]
#endif
        public bool IsAppAssetLibraryPlacementCommonRelationships => AppAssetLibraryPlacementCommonRelationships != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementCommonRelationships(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value)
        {
            value = AppAssetLibraryPlacementCommonRelationships;
            return IsAppAssetLibraryPlacementCommonRelationships;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships PickAppAssetLibraryPlacementCommonRelationships() => AppAssetLibraryPlacementCommonRelationships is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementCommonRelationships' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? AppAssetLibraryPlacementImageRelationshipsVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? AppAssetLibraryPlacementImageRelationshipsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementImageRelationshipsVariant2))]
#endif
        public bool IsAppAssetLibraryPlacementImageRelationshipsVariant2 => AppAssetLibraryPlacementImageRelationshipsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementImageRelationshipsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? value)
        {
            value = AppAssetLibraryPlacementImageRelationshipsVariant2;
            return IsAppAssetLibraryPlacementImageRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2 PickAppAssetLibraryPlacementImageRelationshipsVariant2() => AppAssetLibraryPlacementImageRelationshipsVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementImageRelationshipsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryPlacementImageRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships value) => new AppAssetLibraryPlacementImageRelationships((global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?(AppAssetLibraryPlacementImageRelationships @this) => @this.AppAssetLibraryPlacementCommonRelationships;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementImageRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value)
        {
            AppAssetLibraryPlacementCommonRelationships = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryPlacementImageRelationships FromAppAssetLibraryPlacementCommonRelationships(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? value) => new AppAssetLibraryPlacementImageRelationships(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryPlacementImageRelationships(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2 value) => new AppAssetLibraryPlacementImageRelationships((global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2?(AppAssetLibraryPlacementImageRelationships @this) => @this.AppAssetLibraryPlacementImageRelationshipsVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementImageRelationships(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? value)
        {
            AppAssetLibraryPlacementImageRelationshipsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryPlacementImageRelationships FromAppAssetLibraryPlacementImageRelationshipsVariant2(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? value) => new AppAssetLibraryPlacementImageRelationships(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementImageRelationships(
            global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships? appAssetLibraryPlacementCommonRelationships,
            global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2? appAssetLibraryPlacementImageRelationshipsVariant2
            )
        {
            AppAssetLibraryPlacementCommonRelationships = appAssetLibraryPlacementCommonRelationships;
            AppAssetLibraryPlacementImageRelationshipsVariant2 = appAssetLibraryPlacementImageRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryPlacementImageRelationshipsVariant2 as object ??
            AppAssetLibraryPlacementCommonRelationships as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacementCommonRelationships?.ToString() ??
            AppAssetLibraryPlacementImageRelationshipsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacementCommonRelationships && IsAppAssetLibraryPlacementImageRelationshipsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships, TResult>? appAssetLibraryPlacementCommonRelationships = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2, TResult>? appAssetLibraryPlacementImageRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0 && appAssetLibraryPlacementCommonRelationships != null)
            {
                return appAssetLibraryPlacementCommonRelationships(__value0);
            }
            else if (AppAssetLibraryPlacementImageRelationshipsVariant2 is { } __value1 && appAssetLibraryPlacementImageRelationshipsVariant2 != null)
            {
                return appAssetLibraryPlacementImageRelationshipsVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships>? appAssetLibraryPlacementCommonRelationships = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2>? appAssetLibraryPlacementImageRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0)
            {
                appAssetLibraryPlacementCommonRelationships?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementImageRelationshipsVariant2 is { } __value1)
            {
                appAssetLibraryPlacementImageRelationshipsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships>? appAssetLibraryPlacementCommonRelationships = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2>? appAssetLibraryPlacementImageRelationshipsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonRelationships is { } __value0)
            {
                appAssetLibraryPlacementCommonRelationships?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementImageRelationshipsVariant2 is { } __value1)
            {
                appAssetLibraryPlacementImageRelationshipsVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacementCommonRelationships,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships),
                AppAssetLibraryPlacementImageRelationshipsVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AppAssetLibraryPlacementImageRelationships other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships?>.Default.Equals(AppAssetLibraryPlacementCommonRelationships, other.AppAssetLibraryPlacementCommonRelationships) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2?>.Default.Equals(AppAssetLibraryPlacementImageRelationshipsVariant2, other.AppAssetLibraryPlacementImageRelationshipsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryPlacementImageRelationships obj1, AppAssetLibraryPlacementImageRelationships obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryPlacementImageRelationships>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryPlacementImageRelationships obj1, AppAssetLibraryPlacementImageRelationships obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryPlacementImageRelationships o && Equals(o);
        }
    }
}
