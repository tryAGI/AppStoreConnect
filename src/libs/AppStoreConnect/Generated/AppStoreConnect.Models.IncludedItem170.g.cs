#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem170 : global::System.IEquatable<IncludedItem170>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCodeResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionOfferCodeCustomCode? SubscriptionOfferCodeCustomCodes { get; init; }
#else
        public global::AppStoreConnect.SubscriptionOfferCodeCustomCode? SubscriptionOfferCodeCustomCodes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionOfferCodeCustomCodes))]
#endif
        public bool IsSubscriptionOfferCodeCustomCodes => SubscriptionOfferCodeCustomCodes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionOfferCodeCustomCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionOfferCodeCustomCode? value)
        {
            value = SubscriptionOfferCodeCustomCodes;
            return IsSubscriptionOfferCodeCustomCodes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCodeCustomCode PickSubscriptionOfferCodeCustomCodes() => SubscriptionOfferCodeCustomCodes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionOfferCodeCustomCodes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? SubscriptionOfferCodeOneTimeUseCodes { get; init; }
#else
        public global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? SubscriptionOfferCodeOneTimeUseCodes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionOfferCodeOneTimeUseCodes))]
#endif
        public bool IsSubscriptionOfferCodeOneTimeUseCodes => SubscriptionOfferCodeOneTimeUseCodes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionOfferCodeOneTimeUseCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? value)
        {
            value = SubscriptionOfferCodeOneTimeUseCodes;
            return IsSubscriptionOfferCodeOneTimeUseCodes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode PickSubscriptionOfferCodeOneTimeUseCodes() => SubscriptionOfferCodeOneTimeUseCodes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionOfferCodeOneTimeUseCodes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionOfferCodePrice? SubscriptionOfferCodePrices1 { get; init; }
#else
        public global::AppStoreConnect.SubscriptionOfferCodePrice? SubscriptionOfferCodePrices1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionOfferCodePrices1))]
#endif
        public bool IsSubscriptionOfferCodePrices1 => SubscriptionOfferCodePrices1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionOfferCodePrices1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionOfferCodePrice? value)
        {
            value = SubscriptionOfferCodePrices1;
            return IsSubscriptionOfferCodePrices1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCodePrice PickSubscriptionOfferCodePrices1() => SubscriptionOfferCodePrices1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionOfferCodePrices1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Subscription? SubscriptionOfferCodePrices2 { get; init; }
#else
        public global::AppStoreConnect.Subscription? SubscriptionOfferCodePrices2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionOfferCodePrices2))]
#endif
        public bool IsSubscriptionOfferCodePrices2 => SubscriptionOfferCodePrices2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionOfferCodePrices2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Subscription? value)
        {
            value = SubscriptionOfferCodePrices2;
            return IsSubscriptionOfferCodePrices2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Subscription PickSubscriptionOfferCodePrices2() => SubscriptionOfferCodePrices2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionOfferCodePrices2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodeCustomCode value) => new IncludedItem170((global::AppStoreConnect.SubscriptionOfferCodeCustomCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionOfferCodeCustomCode?(IncludedItem170 @this) => @this.SubscriptionOfferCodeCustomCodes;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodeCustomCode? value)
        {
            SubscriptionOfferCodeCustomCodes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem170 FromSubscriptionOfferCodeCustomCodes(global::AppStoreConnect.SubscriptionOfferCodeCustomCode? value) => new IncludedItem170(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode value) => new IncludedItem170((global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode?(IncludedItem170 @this) => @this.SubscriptionOfferCodeOneTimeUseCodes;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? value)
        {
            SubscriptionOfferCodeOneTimeUseCodes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem170 FromSubscriptionOfferCodeOneTimeUseCodes(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? value) => new IncludedItem170(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodePrice value) => new IncludedItem170((global::AppStoreConnect.SubscriptionOfferCodePrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionOfferCodePrice?(IncludedItem170 @this) => @this.SubscriptionOfferCodePrices1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem170(global::AppStoreConnect.SubscriptionOfferCodePrice? value)
        {
            SubscriptionOfferCodePrices1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem170 FromSubscriptionOfferCodePrices1(global::AppStoreConnect.SubscriptionOfferCodePrice? value) => new IncludedItem170(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem170(global::AppStoreConnect.Subscription value) => new IncludedItem170((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem170 @this) => @this.SubscriptionOfferCodePrices2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem170(global::AppStoreConnect.Subscription? value)
        {
            SubscriptionOfferCodePrices2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem170 FromSubscriptionOfferCodePrices2(global::AppStoreConnect.Subscription? value) => new IncludedItem170(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem170(
            global::AppStoreConnect.SubscriptionOfferCodeResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionOfferCodeCustomCode? subscriptionOfferCodeCustomCodes,
            global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode? subscriptionOfferCodeOneTimeUseCodes,
            global::AppStoreConnect.SubscriptionOfferCodePrice? subscriptionOfferCodePrices1,
            global::AppStoreConnect.Subscription? subscriptionOfferCodePrices2
            )
        {
            Type = type;

            SubscriptionOfferCodeCustomCodes = subscriptionOfferCodeCustomCodes;
            SubscriptionOfferCodeOneTimeUseCodes = subscriptionOfferCodeOneTimeUseCodes;
            SubscriptionOfferCodePrices1 = subscriptionOfferCodePrices1;
            SubscriptionOfferCodePrices2 = subscriptionOfferCodePrices2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SubscriptionOfferCodePrices2 as object ??
            SubscriptionOfferCodePrices1 as object ??
            SubscriptionOfferCodeOneTimeUseCodes as object ??
            SubscriptionOfferCodeCustomCodes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SubscriptionOfferCodeCustomCodes?.ToString() ??
            SubscriptionOfferCodeOneTimeUseCodes?.ToString() ??
            SubscriptionOfferCodePrices1?.ToString() ??
            SubscriptionOfferCodePrices2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionOfferCodeCustomCodes && !IsSubscriptionOfferCodeOneTimeUseCodes && !IsSubscriptionOfferCodePrices1 && !IsSubscriptionOfferCodePrices2 || !IsSubscriptionOfferCodeCustomCodes && IsSubscriptionOfferCodeOneTimeUseCodes && !IsSubscriptionOfferCodePrices1 && !IsSubscriptionOfferCodePrices2 || !IsSubscriptionOfferCodeCustomCodes && !IsSubscriptionOfferCodeOneTimeUseCodes && IsSubscriptionOfferCodePrices1 && !IsSubscriptionOfferCodePrices2 || !IsSubscriptionOfferCodeCustomCodes && !IsSubscriptionOfferCodeOneTimeUseCodes && !IsSubscriptionOfferCodePrices1 && IsSubscriptionOfferCodePrices2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionOfferCodeCustomCode, TResult>? subscriptionOfferCodeCustomCodes = null,
            global::System.Func<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode, TResult>? subscriptionOfferCodeOneTimeUseCodes = null,
            global::System.Func<global::AppStoreConnect.SubscriptionOfferCodePrice, TResult>? subscriptionOfferCodePrices1 = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptionOfferCodePrices2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionOfferCodeCustomCodes is { } __value0 && subscriptionOfferCodeCustomCodes != null)
            {
                return subscriptionOfferCodeCustomCodes(__value0);
            }
            else if (SubscriptionOfferCodeOneTimeUseCodes is { } __value1 && subscriptionOfferCodeOneTimeUseCodes != null)
            {
                return subscriptionOfferCodeOneTimeUseCodes(__value1);
            }
            else if (SubscriptionOfferCodePrices1 is { } __value2 && subscriptionOfferCodePrices1 != null)
            {
                return subscriptionOfferCodePrices1(__value2);
            }
            else if (SubscriptionOfferCodePrices2 is { } __value3 && subscriptionOfferCodePrices2 != null)
            {
                return subscriptionOfferCodePrices2(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodeCustomCode>? subscriptionOfferCodeCustomCodes = null,

            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode>? subscriptionOfferCodeOneTimeUseCodes = null,

            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodePrice>? subscriptionOfferCodePrices1 = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptionOfferCodePrices2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionOfferCodeCustomCodes is { } __value0)
            {
                subscriptionOfferCodeCustomCodes?.Invoke(__value0);
            }
            else if (SubscriptionOfferCodeOneTimeUseCodes is { } __value1)
            {
                subscriptionOfferCodeOneTimeUseCodes?.Invoke(__value1);
            }
            else if (SubscriptionOfferCodePrices1 is { } __value2)
            {
                subscriptionOfferCodePrices1?.Invoke(__value2);
            }
            else if (SubscriptionOfferCodePrices2 is { } __value3)
            {
                subscriptionOfferCodePrices2?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodeCustomCode>? subscriptionOfferCodeCustomCodes = null,
            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode>? subscriptionOfferCodeOneTimeUseCodes = null,
            global::System.Action<global::AppStoreConnect.SubscriptionOfferCodePrice>? subscriptionOfferCodePrices1 = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptionOfferCodePrices2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionOfferCodeCustomCodes is { } __value0)
            {
                subscriptionOfferCodeCustomCodes?.Invoke(__value0);
            }
            else if (SubscriptionOfferCodeOneTimeUseCodes is { } __value1)
            {
                subscriptionOfferCodeOneTimeUseCodes?.Invoke(__value1);
            }
            else if (SubscriptionOfferCodePrices1 is { } __value2)
            {
                subscriptionOfferCodePrices1?.Invoke(__value2);
            }
            else if (SubscriptionOfferCodePrices2 is { } __value3)
            {
                subscriptionOfferCodePrices2?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SubscriptionOfferCodeCustomCodes,
                typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode),
                SubscriptionOfferCodeOneTimeUseCodes,
                typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode),
                SubscriptionOfferCodePrices1,
                typeof(global::AppStoreConnect.SubscriptionOfferCodePrice),
                SubscriptionOfferCodePrices2,
                typeof(global::AppStoreConnect.Subscription),
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
        public bool Equals(IncludedItem170 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionOfferCodeCustomCode?>.Default.Equals(SubscriptionOfferCodeCustomCodes, other.SubscriptionOfferCodeCustomCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode?>.Default.Equals(SubscriptionOfferCodeOneTimeUseCodes, other.SubscriptionOfferCodeOneTimeUseCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionOfferCodePrice?>.Default.Equals(SubscriptionOfferCodePrices1, other.SubscriptionOfferCodePrices1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(SubscriptionOfferCodePrices2, other.SubscriptionOfferCodePrices2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem170 obj1, IncludedItem170 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem170>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem170 obj1, IncludedItem170 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem170 o && Equals(o);
        }
    }
}
