#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem143 : global::System.IEquatable<IncludedItem143>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseImageV2? InAppPurchaseImages { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseImageV2? InAppPurchaseImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseImages))]
#endif
        public bool IsInAppPurchaseImages => InAppPurchaseImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchaseImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseImageV2? value)
        {
            value = InAppPurchaseImages;
            return IsInAppPurchaseImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseImageV2 PickInAppPurchaseImages() => IsInAppPurchaseImages
            ? InAppPurchaseImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseLocalizationV2? InAppPurchaseLocalizations { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseLocalizationV2? InAppPurchaseLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseLocalizations))]
#endif
        public bool IsInAppPurchaseLocalizations => InAppPurchaseLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchaseLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseLocalizationV2? value)
        {
            value = InAppPurchaseLocalizations;
            return IsInAppPurchaseLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseLocalizationV2 PickInAppPurchaseLocalizations() => IsInAppPurchaseLocalizations
            ? InAppPurchaseLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseV2? InAppPurchases { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseV2? InAppPurchases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchases))]
#endif
        public bool IsInAppPurchases => InAppPurchases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseV2? value)
        {
            value = InAppPurchases;
            return IsInAppPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseV2 PickInAppPurchases() => IsInAppPurchases
            ? InAppPurchases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchases' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem143(global::AppStoreConnect.InAppPurchaseImageV2 value) => new IncludedItem143((global::AppStoreConnect.InAppPurchaseImageV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseImageV2?(IncludedItem143 @this) => @this.InAppPurchaseImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem143(global::AppStoreConnect.InAppPurchaseImageV2? value)
        {
            InAppPurchaseImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem143 FromInAppPurchaseImages(global::AppStoreConnect.InAppPurchaseImageV2? value) => new IncludedItem143(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem143(global::AppStoreConnect.InAppPurchaseLocalizationV2 value) => new IncludedItem143((global::AppStoreConnect.InAppPurchaseLocalizationV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseLocalizationV2?(IncludedItem143 @this) => @this.InAppPurchaseLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem143(global::AppStoreConnect.InAppPurchaseLocalizationV2? value)
        {
            InAppPurchaseLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem143 FromInAppPurchaseLocalizations(global::AppStoreConnect.InAppPurchaseLocalizationV2? value) => new IncludedItem143(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem143(global::AppStoreConnect.InAppPurchaseV2 value) => new IncludedItem143((global::AppStoreConnect.InAppPurchaseV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseV2?(IncludedItem143 @this) => @this.InAppPurchases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem143(global::AppStoreConnect.InAppPurchaseV2? value)
        {
            InAppPurchases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem143 FromInAppPurchases(global::AppStoreConnect.InAppPurchaseV2? value) => new IncludedItem143(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem143(
            global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchaseImageV2? inAppPurchaseImages,
            global::AppStoreConnect.InAppPurchaseLocalizationV2? inAppPurchaseLocalizations,
            global::AppStoreConnect.InAppPurchaseV2? inAppPurchases
            )
        {
            Type = type;

            InAppPurchaseImages = inAppPurchaseImages;
            InAppPurchaseLocalizations = inAppPurchaseLocalizations;
            InAppPurchases = inAppPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InAppPurchases as object ??
            InAppPurchaseLocalizations as object ??
            InAppPurchaseImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InAppPurchaseImages?.ToString() ??
            InAppPurchaseLocalizations?.ToString() ??
            InAppPurchases?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchases || !IsInAppPurchaseImages && IsInAppPurchaseLocalizations && !IsInAppPurchases || !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && IsInAppPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchaseImageV2, TResult>? inAppPurchaseImages = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseLocalizationV2, TResult>? inAppPurchaseLocalizations = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseV2, TResult>? inAppPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseImages && inAppPurchaseImages != null)
            {
                return inAppPurchaseImages(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations && inAppPurchaseLocalizations != null)
            {
                return inAppPurchaseLocalizations(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchases && inAppPurchases != null)
            {
                return inAppPurchases(InAppPurchases!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.InAppPurchaseImageV2>? inAppPurchaseImages = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseLocalizationV2>? inAppPurchaseLocalizations = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseV2>? inAppPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseImages)
            {
                inAppPurchaseImages?.Invoke(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations)
            {
                inAppPurchaseLocalizations?.Invoke(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.InAppPurchaseImageV2>? inAppPurchaseImages = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseLocalizationV2>? inAppPurchaseLocalizations = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseV2>? inAppPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseImages)
            {
                inAppPurchaseImages?.Invoke(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations)
            {
                inAppPurchaseLocalizations?.Invoke(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InAppPurchaseImages,
                typeof(global::AppStoreConnect.InAppPurchaseImageV2),
                InAppPurchaseLocalizations,
                typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2),
                InAppPurchases,
                typeof(global::AppStoreConnect.InAppPurchaseV2),
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
        public bool Equals(IncludedItem143 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseImageV2?>.Default.Equals(InAppPurchaseImages, other.InAppPurchaseImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseLocalizationV2?>.Default.Equals(InAppPurchaseLocalizations, other.InAppPurchaseLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseV2?>.Default.Equals(InAppPurchases, other.InAppPurchases)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem143 obj1, IncludedItem143 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem143>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem143 obj1, IncludedItem143 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem143 o && Equals(o);
        }
    }
}
