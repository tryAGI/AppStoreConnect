#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem26 : global::System.IEquatable<IncludedItem26>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPricePointsV3ResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.App PickApps() => IsApps
            ? Apps!
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
        public global::AppStoreConnect.Territory PickTerritories() => IsTerritories
            ? Territories!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem26(global::AppStoreConnect.App value) => new IncludedItem26((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem26 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem26(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem26 FromApps(global::AppStoreConnect.App? value) => new IncludedItem26(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem26(global::AppStoreConnect.Territory value) => new IncludedItem26((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem26 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem26(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem26 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem26(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem26(
            global::AppStoreConnect.AppPricePointsV3ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            Apps = apps;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            Apps as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsTerritories || !IsApps && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps && apps != null)
            {
                return apps(Apps!);
            }
            else if (IsTerritories && territories != null)
            {
                return territories(Territories!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
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
        public bool Equals(IncludedItem26 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem26 obj1, IncludedItem26 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem26>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem26 obj1, IncludedItem26 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem26 o && Equals(o);
        }
    }
}
