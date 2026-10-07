#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem162 : global::System.IEquatable<IncludedItem162>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroupLocalizationV2? SubscriptionGroupLocalizations { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroupLocalizationV2? SubscriptionGroupLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroupLocalizations))]
#endif
        public bool IsSubscriptionGroupLocalizations => SubscriptionGroupLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGroupLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroupLocalizationV2? value)
        {
            value = SubscriptionGroupLocalizations;
            return IsSubscriptionGroupLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupLocalizationV2 PickSubscriptionGroupLocalizations() => SubscriptionGroupLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroupLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroups))]
#endif
        public bool IsSubscriptionGroups => SubscriptionGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroup? value)
        {
            value = SubscriptionGroups;
            return IsSubscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroup PickSubscriptionGroups() => SubscriptionGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroups' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem162(global::AppStoreConnect.SubscriptionGroupLocalizationV2 value) => new IncludedItem162((global::AppStoreConnect.SubscriptionGroupLocalizationV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupLocalizationV2?(IncludedItem162 @this) => @this.SubscriptionGroupLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem162(global::AppStoreConnect.SubscriptionGroupLocalizationV2? value)
        {
            SubscriptionGroupLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem162 FromSubscriptionGroupLocalizations(global::AppStoreConnect.SubscriptionGroupLocalizationV2? value) => new IncludedItem162(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem162(global::AppStoreConnect.SubscriptionGroup value) => new IncludedItem162((global::AppStoreConnect.SubscriptionGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroup?(IncludedItem162 @this) => @this.SubscriptionGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem162(global::AppStoreConnect.SubscriptionGroup? value)
        {
            SubscriptionGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem162 FromSubscriptionGroups(global::AppStoreConnect.SubscriptionGroup? value) => new IncludedItem162(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem162(
            global::AppStoreConnect.SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionGroupLocalizationV2? subscriptionGroupLocalizations,
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups
            )
        {
            Type = type;

            SubscriptionGroupLocalizations = subscriptionGroupLocalizations;
            SubscriptionGroups = subscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SubscriptionGroups as object ??
            SubscriptionGroupLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SubscriptionGroupLocalizations?.ToString() ??
            SubscriptionGroups?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionGroupLocalizations && !IsSubscriptionGroups || !IsSubscriptionGroupLocalizations && IsSubscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionGroupLocalizationV2, TResult>? subscriptionGroupLocalizations = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGroup, TResult>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionGroupLocalizations is { } __value0 && subscriptionGroupLocalizations != null)
            {
                return subscriptionGroupLocalizations(__value0);
            }
            else if (SubscriptionGroups is { } __value1 && subscriptionGroups != null)
            {
                return subscriptionGroups(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.SubscriptionGroupLocalizationV2>? subscriptionGroupLocalizations = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionGroupLocalizations is { } __value0)
            {
                subscriptionGroupLocalizations?.Invoke(__value0);
            }
            else if (SubscriptionGroups is { } __value1)
            {
                subscriptionGroups?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.SubscriptionGroupLocalizationV2>? subscriptionGroupLocalizations = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionGroupLocalizations is { } __value0)
            {
                subscriptionGroupLocalizations?.Invoke(__value0);
            }
            else if (SubscriptionGroups is { } __value1)
            {
                subscriptionGroups?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SubscriptionGroupLocalizations,
                typeof(global::AppStoreConnect.SubscriptionGroupLocalizationV2),
                SubscriptionGroups,
                typeof(global::AppStoreConnect.SubscriptionGroup),
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
        public bool Equals(IncludedItem162 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroupLocalizationV2?>.Default.Equals(SubscriptionGroupLocalizations, other.SubscriptionGroupLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroup?>.Default.Equals(SubscriptionGroups, other.SubscriptionGroups)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem162 obj1, IncludedItem162 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem162>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem162 obj1, IncludedItem162 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem162 o && Equals(o);
        }
    }
}
