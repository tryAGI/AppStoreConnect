#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem73 : global::System.IEquatable<IncludedItem73>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.CustomerReviewResponseV1? CustomerReviewResponses { get; init; }
#else
        public global::AppStoreConnect.CustomerReviewResponseV1? CustomerReviewResponses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomerReviewResponses))]
#endif
        public bool IsCustomerReviewResponses => CustomerReviewResponses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomerReviewResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CustomerReviewResponseV1? value)
        {
            value = CustomerReviewResponses;
            return IsCustomerReviewResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CustomerReviewResponseV1 PickCustomerReviewResponses() => IsCustomerReviewResponses
            ? CustomerReviewResponses!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomerReviewResponses' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem73(global::AppStoreConnect.CustomerReviewResponseV1 value) => new IncludedItem73((global::AppStoreConnect.CustomerReviewResponseV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CustomerReviewResponseV1?(IncludedItem73 @this) => @this.CustomerReviewResponses;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem73(global::AppStoreConnect.CustomerReviewResponseV1? value)
        {
            CustomerReviewResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem73 FromCustomerReviewResponses(global::AppStoreConnect.CustomerReviewResponseV1? value) => new IncludedItem73(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem73(global::AppStoreConnect.Territory value) => new IncludedItem73((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem73 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem73(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem73 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem73(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem73(
            global::AppStoreConnect.CustomerReviewResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.CustomerReviewResponseV1? customerReviewResponses,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            CustomerReviewResponses = customerReviewResponses;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            CustomerReviewResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CustomerReviewResponses?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCustomerReviewResponses && !IsTerritories || !IsCustomerReviewResponses && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.CustomerReviewResponseV1, TResult>? customerReviewResponses = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReviewResponses && customerReviewResponses != null)
            {
                return customerReviewResponses(CustomerReviewResponses!);
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
            global::System.Action<global::AppStoreConnect.CustomerReviewResponseV1>? customerReviewResponses = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReviewResponses)
            {
                customerReviewResponses?.Invoke(CustomerReviewResponses!);
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
            global::System.Action<global::AppStoreConnect.CustomerReviewResponseV1>? customerReviewResponses = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomerReviewResponses)
            {
                customerReviewResponses?.Invoke(CustomerReviewResponses!);
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
                CustomerReviewResponses,
                typeof(global::AppStoreConnect.CustomerReviewResponseV1),
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
        public bool Equals(IncludedItem73 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CustomerReviewResponseV1?>.Default.Equals(CustomerReviewResponses, other.CustomerReviewResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem73 obj1, IncludedItem73 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem73>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem73 obj1, IncludedItem73 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem73 o && Equals(o);
        }
    }
}
