#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem175 : global::System.IEquatable<IncludedItem175>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionVersionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionImageV2? SubscriptionImages { get; init; }
#else
        public global::AppStoreConnect.SubscriptionImageV2? SubscriptionImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionImages))]
#endif
        public bool IsSubscriptionImages => SubscriptionImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionImageV2? value)
        {
            value = SubscriptionImages;
            return IsSubscriptionImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionImageV2 PickSubscriptionImages() => IsSubscriptionImages
            ? SubscriptionImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionLocalizationV2? SubscriptionLocalizations { get; init; }
#else
        public global::AppStoreConnect.SubscriptionLocalizationV2? SubscriptionLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionLocalizations))]
#endif
        public bool IsSubscriptionLocalizations => SubscriptionLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionLocalizationV2? value)
        {
            value = SubscriptionLocalizations;
            return IsSubscriptionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionLocalizationV2 PickSubscriptionLocalizations() => IsSubscriptionLocalizations
            ? SubscriptionLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Subscription? Subscriptions { get; init; }
#else
        public global::AppStoreConnect.Subscription? Subscriptions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Subscriptions))]
#endif
        public bool IsSubscriptions => Subscriptions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Subscription? value)
        {
            value = Subscriptions;
            return IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Subscription PickSubscriptions() => IsSubscriptions
            ? Subscriptions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subscriptions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem175(global::AppStoreConnect.SubscriptionImageV2 value) => new IncludedItem175((global::AppStoreConnect.SubscriptionImageV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionImageV2?(IncludedItem175 @this) => @this.SubscriptionImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem175(global::AppStoreConnect.SubscriptionImageV2? value)
        {
            SubscriptionImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem175 FromSubscriptionImages(global::AppStoreConnect.SubscriptionImageV2? value) => new IncludedItem175(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem175(global::AppStoreConnect.SubscriptionLocalizationV2 value) => new IncludedItem175((global::AppStoreConnect.SubscriptionLocalizationV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionLocalizationV2?(IncludedItem175 @this) => @this.SubscriptionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem175(global::AppStoreConnect.SubscriptionLocalizationV2? value)
        {
            SubscriptionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem175 FromSubscriptionLocalizations(global::AppStoreConnect.SubscriptionLocalizationV2? value) => new IncludedItem175(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem175(global::AppStoreConnect.Subscription value) => new IncludedItem175((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem175 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem175(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem175 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem175(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem175(
            global::AppStoreConnect.SubscriptionVersionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionImageV2? subscriptionImages,
            global::AppStoreConnect.SubscriptionLocalizationV2? subscriptionLocalizations,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            SubscriptionImages = subscriptionImages;
            SubscriptionLocalizations = subscriptionLocalizations;
            Subscriptions = subscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            SubscriptionLocalizations as object ??
            SubscriptionImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SubscriptionImages?.ToString() ??
            SubscriptionLocalizations?.ToString() ??
            Subscriptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionImages && !IsSubscriptionLocalizations && !IsSubscriptions || !IsSubscriptionImages && IsSubscriptionLocalizations && !IsSubscriptions || !IsSubscriptionImages && !IsSubscriptionLocalizations && IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionImageV2, TResult>? subscriptionImages = null,
            global::System.Func<global::AppStoreConnect.SubscriptionLocalizationV2, TResult>? subscriptionLocalizations = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionImages && subscriptionImages != null)
            {
                return subscriptionImages(SubscriptionImages!);
            }
            else if (IsSubscriptionLocalizations && subscriptionLocalizations != null)
            {
                return subscriptionLocalizations(SubscriptionLocalizations!);
            }
            else if (IsSubscriptions && subscriptions != null)
            {
                return subscriptions(Subscriptions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.SubscriptionImageV2>? subscriptionImages = null,

            global::System.Action<global::AppStoreConnect.SubscriptionLocalizationV2>? subscriptionLocalizations = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionImages)
            {
                subscriptionImages?.Invoke(SubscriptionImages!);
            }
            else if (IsSubscriptionLocalizations)
            {
                subscriptionLocalizations?.Invoke(SubscriptionLocalizations!);
            }
            else if (IsSubscriptions)
            {
                subscriptions?.Invoke(Subscriptions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.SubscriptionImageV2>? subscriptionImages = null,
            global::System.Action<global::AppStoreConnect.SubscriptionLocalizationV2>? subscriptionLocalizations = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionImages)
            {
                subscriptionImages?.Invoke(SubscriptionImages!);
            }
            else if (IsSubscriptionLocalizations)
            {
                subscriptionLocalizations?.Invoke(SubscriptionLocalizations!);
            }
            else if (IsSubscriptions)
            {
                subscriptions?.Invoke(Subscriptions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SubscriptionImages,
                typeof(global::AppStoreConnect.SubscriptionImageV2),
                SubscriptionLocalizations,
                typeof(global::AppStoreConnect.SubscriptionLocalizationV2),
                Subscriptions,
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
        public bool Equals(IncludedItem175 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionImageV2?>.Default.Equals(SubscriptionImages, other.SubscriptionImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionLocalizationV2?>.Default.Equals(SubscriptionLocalizations, other.SubscriptionLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem175 obj1, IncludedItem175 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem175>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem175 obj1, IncludedItem175 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem175 o && Equals(o);
        }
    }
}
