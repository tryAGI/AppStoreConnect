#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem136 : global::System.IEquatable<IncludedItem136>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? InAppPurchaseOfferCodeCustomCodes { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? InAppPurchaseOfferCodeCustomCodes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseOfferCodeCustomCodes))]
#endif
        public bool IsInAppPurchaseOfferCodeCustomCodes => InAppPurchaseOfferCodeCustomCodes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchaseOfferCodeCustomCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? value)
        {
            value = InAppPurchaseOfferCodeCustomCodes;
            return IsInAppPurchaseOfferCodeCustomCodes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode PickInAppPurchaseOfferCodeCustomCodes() => IsInAppPurchaseOfferCodeCustomCodes
            ? InAppPurchaseOfferCodeCustomCodes!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseOfferCodeCustomCodes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? InAppPurchaseOfferCodeOneTimeUseCodes { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? InAppPurchaseOfferCodeOneTimeUseCodes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseOfferCodeOneTimeUseCodes))]
#endif
        public bool IsInAppPurchaseOfferCodeOneTimeUseCodes => InAppPurchaseOfferCodeOneTimeUseCodes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchaseOfferCodeOneTimeUseCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? value)
        {
            value = InAppPurchaseOfferCodeOneTimeUseCodes;
            return IsInAppPurchaseOfferCodeOneTimeUseCodes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode PickInAppPurchaseOfferCodeOneTimeUseCodes() => IsInAppPurchaseOfferCodeOneTimeUseCodes
            ? InAppPurchaseOfferCodeOneTimeUseCodes!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseOfferCodeOneTimeUseCodes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseOfferPrice? InAppPurchaseOfferPrices { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseOfferPrice? InAppPurchaseOfferPrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseOfferPrices))]
#endif
        public bool IsInAppPurchaseOfferPrices => InAppPurchaseOfferPrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchaseOfferPrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseOfferPrice? value)
        {
            value = InAppPurchaseOfferPrices;
            return IsInAppPurchaseOfferPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferPrice PickInAppPurchaseOfferPrices() => IsInAppPurchaseOfferPrices
            ? InAppPurchaseOfferPrices!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseOfferPrices' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode value) => new IncludedItem136((global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode?(IncludedItem136 @this) => @this.InAppPurchaseOfferCodeCustomCodes;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? value)
        {
            InAppPurchaseOfferCodeCustomCodes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem136 FromInAppPurchaseOfferCodeCustomCodes(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? value) => new IncludedItem136(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode value) => new IncludedItem136((global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode?(IncludedItem136 @this) => @this.InAppPurchaseOfferCodeOneTimeUseCodes;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? value)
        {
            InAppPurchaseOfferCodeOneTimeUseCodes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem136 FromInAppPurchaseOfferCodeOneTimeUseCodes(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? value) => new IncludedItem136(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferPrice value) => new IncludedItem136((global::AppStoreConnect.InAppPurchaseOfferPrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseOfferPrice?(IncludedItem136 @this) => @this.InAppPurchaseOfferPrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem136(global::AppStoreConnect.InAppPurchaseOfferPrice? value)
        {
            InAppPurchaseOfferPrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem136 FromInAppPurchaseOfferPrices(global::AppStoreConnect.InAppPurchaseOfferPrice? value) => new IncludedItem136(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem136(
            global::AppStoreConnect.InAppPurchaseOfferCodesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode? inAppPurchaseOfferCodeCustomCodes,
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode? inAppPurchaseOfferCodeOneTimeUseCodes,
            global::AppStoreConnect.InAppPurchaseOfferPrice? inAppPurchaseOfferPrices
            )
        {
            Type = type;

            InAppPurchaseOfferCodeCustomCodes = inAppPurchaseOfferCodeCustomCodes;
            InAppPurchaseOfferCodeOneTimeUseCodes = inAppPurchaseOfferCodeOneTimeUseCodes;
            InAppPurchaseOfferPrices = inAppPurchaseOfferPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InAppPurchaseOfferPrices as object ??
            InAppPurchaseOfferCodeOneTimeUseCodes as object ??
            InAppPurchaseOfferCodeCustomCodes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InAppPurchaseOfferCodeCustomCodes?.ToString() ??
            InAppPurchaseOfferCodeOneTimeUseCodes?.ToString() ??
            InAppPurchaseOfferPrices?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchaseOfferCodeCustomCodes && !IsInAppPurchaseOfferCodeOneTimeUseCodes && !IsInAppPurchaseOfferPrices || !IsInAppPurchaseOfferCodeCustomCodes && IsInAppPurchaseOfferCodeOneTimeUseCodes && !IsInAppPurchaseOfferPrices || !IsInAppPurchaseOfferCodeCustomCodes && !IsInAppPurchaseOfferCodeOneTimeUseCodes && IsInAppPurchaseOfferPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode, TResult>? inAppPurchaseOfferCodeCustomCodes = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode, TResult>? inAppPurchaseOfferCodeOneTimeUseCodes = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseOfferPrice, TResult>? inAppPurchaseOfferPrices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseOfferCodeCustomCodes && inAppPurchaseOfferCodeCustomCodes != null)
            {
                return inAppPurchaseOfferCodeCustomCodes(InAppPurchaseOfferCodeCustomCodes!);
            }
            else if (IsInAppPurchaseOfferCodeOneTimeUseCodes && inAppPurchaseOfferCodeOneTimeUseCodes != null)
            {
                return inAppPurchaseOfferCodeOneTimeUseCodes(InAppPurchaseOfferCodeOneTimeUseCodes!);
            }
            else if (IsInAppPurchaseOfferPrices && inAppPurchaseOfferPrices != null)
            {
                return inAppPurchaseOfferPrices(InAppPurchaseOfferPrices!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode>? inAppPurchaseOfferCodeCustomCodes = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode>? inAppPurchaseOfferCodeOneTimeUseCodes = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferPrice>? inAppPurchaseOfferPrices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseOfferCodeCustomCodes)
            {
                inAppPurchaseOfferCodeCustomCodes?.Invoke(InAppPurchaseOfferCodeCustomCodes!);
            }
            else if (IsInAppPurchaseOfferCodeOneTimeUseCodes)
            {
                inAppPurchaseOfferCodeOneTimeUseCodes?.Invoke(InAppPurchaseOfferCodeOneTimeUseCodes!);
            }
            else if (IsInAppPurchaseOfferPrices)
            {
                inAppPurchaseOfferPrices?.Invoke(InAppPurchaseOfferPrices!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode>? inAppPurchaseOfferCodeCustomCodes = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode>? inAppPurchaseOfferCodeOneTimeUseCodes = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferPrice>? inAppPurchaseOfferPrices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseOfferCodeCustomCodes)
            {
                inAppPurchaseOfferCodeCustomCodes?.Invoke(InAppPurchaseOfferCodeCustomCodes!);
            }
            else if (IsInAppPurchaseOfferCodeOneTimeUseCodes)
            {
                inAppPurchaseOfferCodeOneTimeUseCodes?.Invoke(InAppPurchaseOfferCodeOneTimeUseCodes!);
            }
            else if (IsInAppPurchaseOfferPrices)
            {
                inAppPurchaseOfferPrices?.Invoke(InAppPurchaseOfferPrices!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InAppPurchaseOfferCodeCustomCodes,
                typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode),
                InAppPurchaseOfferCodeOneTimeUseCodes,
                typeof(global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode),
                InAppPurchaseOfferPrices,
                typeof(global::AppStoreConnect.InAppPurchaseOfferPrice),
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
        public bool Equals(IncludedItem136 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode?>.Default.Equals(InAppPurchaseOfferCodeCustomCodes, other.InAppPurchaseOfferCodeCustomCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCode?>.Default.Equals(InAppPurchaseOfferCodeOneTimeUseCodes, other.InAppPurchaseOfferCodeOneTimeUseCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseOfferPrice?>.Default.Equals(InAppPurchaseOfferPrices, other.InAppPurchaseOfferPrices)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem136 obj1, IncludedItem136 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem136>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem136 obj1, IncludedItem136 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem136 o && Equals(o);
        }
    }
}
