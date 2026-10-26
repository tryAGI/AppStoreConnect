#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem30 : global::System.IEquatable<IncludedItem30>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPriceScheduleResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPriceV2? AppPrices { get; init; }
#else
        public global::AppStoreConnect.AppPriceV2? AppPrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPrices))]
#endif
        public bool IsAppPrices => AppPrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppPrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPriceV2? value)
        {
            value = AppPrices;
            return IsAppPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPriceV2 PickAppPrices() => AppPrices is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPrices' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Territory? Territories { get; init; }
#else
        public global::AppStoreConnect.Territory? Territories { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Territories))]
#endif
        public bool IsTerritories => Territories != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTerritories(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Territory? value)
        {
            value = Territories;
            return IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Territory PickTerritories() => Territories is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem30(global::AppStoreConnect.AppPriceV2 value) => new IncludedItem30((global::AppStoreConnect.AppPriceV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPriceV2?(IncludedItem30 @this) => @this.AppPrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(global::AppStoreConnect.AppPriceV2? value)
        {
            AppPrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem30 FromAppPrices(global::AppStoreConnect.AppPriceV2? value) => new IncludedItem30(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem30(global::AppStoreConnect.App value) => new IncludedItem30((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem30 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem30 FromApps(global::AppStoreConnect.App? value) => new IncludedItem30(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem30(global::AppStoreConnect.Territory value) => new IncludedItem30((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem30 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem30 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem30(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(
            global::AppStoreConnect.AppPriceScheduleResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppPriceV2? appPrices,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            AppPrices = appPrices;
            Apps = apps;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            Apps as object ??
            AppPrices as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppPrices?.ToString() ??
            Apps?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppPrices && !IsApps && !IsTerritories || !IsAppPrices && IsApps && !IsTerritories || !IsAppPrices && !IsApps && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppPriceV2, TResult>? appPrices = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppPrices is { } __value0 && appPrices != null)
            {
                return appPrices(__value0);
            }
            else if (Apps is { } __value1 && apps != null)
            {
                return apps(__value1);
            }
            else if (Territories is { } __value2 && territories != null)
            {
                return territories(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppPriceV2>? appPrices = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppPrices is { } __value0)
            {
                appPrices?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (Territories is { } __value2)
            {
                territories?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppPriceV2>? appPrices = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppPrices is { } __value0)
            {
                appPrices?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (Territories is { } __value2)
            {
                territories?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppPrices,
                typeof(global::AppStoreConnect.AppPriceV2),
                Apps,
                typeof(global::AppStoreConnect.App),
                Territories,
                typeof(global::AppStoreConnect.Territory),
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
        public bool Equals(IncludedItem30 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPriceV2?>.Default.Equals(AppPrices, other.AppPrices) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem30 obj1, IncludedItem30 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem30>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem30 obj1, IncludedItem30 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem30 o && Equals(o);
        }
    }
}
