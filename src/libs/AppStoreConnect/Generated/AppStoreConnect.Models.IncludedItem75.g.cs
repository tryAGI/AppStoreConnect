#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem75 : global::System.IEquatable<IncludedItem75>
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
        public global::AppStoreConnect.CustomerReviewResponseV1 PickCustomerReviewResponses() => CustomerReviewResponses is { } value
            ? value
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
        public global::AppStoreConnect.Territory PickTerritories() => Territories is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem75(global::AppStoreConnect.CustomerReviewResponseV1 value) => new IncludedItem75((global::AppStoreConnect.CustomerReviewResponseV1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CustomerReviewResponseV1?(IncludedItem75 @this) => @this.CustomerReviewResponses;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem75(global::AppStoreConnect.CustomerReviewResponseV1? value)
        {
            CustomerReviewResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem75 FromCustomerReviewResponses(global::AppStoreConnect.CustomerReviewResponseV1? value) => new IncludedItem75(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem75(global::AppStoreConnect.Territory value) => new IncludedItem75((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem75 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem75(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem75 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem75(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem75(
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

            if (CustomerReviewResponses is { } __value0 && customerReviewResponses != null)
            {
                return customerReviewResponses(__value0);
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
            global::System.Action<global::AppStoreConnect.CustomerReviewResponseV1>? customerReviewResponses = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CustomerReviewResponses is { } __value0)
            {
                customerReviewResponses?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.CustomerReviewResponseV1>? customerReviewResponses = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CustomerReviewResponses is { } __value0)
            {
                customerReviewResponses?.Invoke(__value0);
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
        public bool Equals(IncludedItem75 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CustomerReviewResponseV1?>.Default.Equals(CustomerReviewResponses, other.CustomerReviewResponses) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem75 obj1, IncludedItem75 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem75>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem75 obj1, IncludedItem75 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem75 o && Equals(o);
        }
    }
}
