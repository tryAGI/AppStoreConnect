#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem141 : global::System.IEquatable<IncludedItem141>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchasePrice? InAppPurchasePrices { get; init; }
#else
        public global::AppStoreConnect.InAppPurchasePrice? InAppPurchasePrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchasePrices))]
#endif
        public bool IsInAppPurchasePrices => InAppPurchasePrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchasePrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchasePrice? value)
        {
            value = InAppPurchasePrices;
            return IsInAppPurchasePrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchasePrice PickInAppPurchasePrices() => InAppPurchasePrices is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchasePrices' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem141(global::AppStoreConnect.InAppPurchasePrice value) => new IncludedItem141((global::AppStoreConnect.InAppPurchasePrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchasePrice?(IncludedItem141 @this) => @this.InAppPurchasePrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem141(global::AppStoreConnect.InAppPurchasePrice? value)
        {
            InAppPurchasePrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem141 FromInAppPurchasePrices(global::AppStoreConnect.InAppPurchasePrice? value) => new IncludedItem141(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem141(global::AppStoreConnect.Territory value) => new IncludedItem141((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem141 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem141(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem141 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem141(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem141(
            global::AppStoreConnect.InAppPurchasePriceScheduleResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchasePrice? inAppPurchasePrices,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            InAppPurchasePrices = inAppPurchasePrices;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            InAppPurchasePrices as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InAppPurchasePrices?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchasePrices && !IsTerritories || !IsInAppPurchasePrices && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchasePrice, TResult>? inAppPurchasePrices = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchasePrices is { } __value0 && inAppPurchasePrices != null)
            {
                return inAppPurchasePrices(__value0);
            }
            else if (Territories is { } __value1 && territories != null)
            {
                return territories(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.InAppPurchasePrice>? inAppPurchasePrices = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchasePrices is { } __value0)
            {
                inAppPurchasePrices?.Invoke(__value0);
            }
            else if (Territories is { } __value1)
            {
                territories?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.InAppPurchasePrice>? inAppPurchasePrices = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchasePrices is { } __value0)
            {
                inAppPurchasePrices?.Invoke(__value0);
            }
            else if (Territories is { } __value1)
            {
                territories?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InAppPurchasePrices,
                typeof(global::AppStoreConnect.InAppPurchasePrice),
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
        public bool Equals(IncludedItem141 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchasePrice?>.Default.Equals(InAppPurchasePrices, other.InAppPurchasePrices) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem141 obj1, IncludedItem141 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem141>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem141 obj1, IncludedItem141 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem141 o && Equals(o);
        }
    }
}
