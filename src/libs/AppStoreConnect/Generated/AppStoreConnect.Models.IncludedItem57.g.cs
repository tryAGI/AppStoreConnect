#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem57 : global::System.IEquatable<IncludedItem57>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaTester? BetaTesters { get; init; }
#else
        public global::AppStoreConnect.BetaTester? BetaTesters { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaTesters))]
#endif
        public bool IsBetaTesters => BetaTesters != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaTesters(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaTester? value)
        {
            value = BetaTesters;
            return IsBetaTesters;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaTester PickBetaTesters() => BetaTesters is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaTesters' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? Builds { get; init; }
#else
        public global::AppStoreConnect.Build? Builds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builds))]
#endif
        public bool IsBuilds => Builds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuilds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = Builds;
            return IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuilds() => Builds is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem57(global::AppStoreConnect.BetaTester value) => new IncludedItem57((global::AppStoreConnect.BetaTester?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaTester?(IncludedItem57 @this) => @this.BetaTesters;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem57(global::AppStoreConnect.BetaTester? value)
        {
            BetaTesters = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem57 FromBetaTesters(global::AppStoreConnect.BetaTester? value) => new IncludedItem57(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem57(global::AppStoreConnect.Build value) => new IncludedItem57((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem57 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem57(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem57 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem57(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem57(
            global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BetaTester? betaTesters,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            BetaTesters = betaTesters;
            Builds = builds;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Builds as object ??
            BetaTesters as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaTesters?.ToString() ??
            Builds?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaTesters && !IsBuilds || !IsBetaTesters && IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BetaTester, TResult>? betaTesters = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaTesters is { } __value0 && betaTesters != null)
            {
                return betaTesters(__value0);
            }
            else if (Builds is { } __value1 && builds != null)
            {
                return builds(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaTesters is { } __value0)
            {
                betaTesters?.Invoke(__value0);
            }
            else if (Builds is { } __value1)
            {
                builds?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaTesters is { } __value0)
            {
                betaTesters?.Invoke(__value0);
            }
            else if (Builds is { } __value1)
            {
                builds?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaTesters,
                typeof(global::AppStoreConnect.BetaTester),
                Builds,
                typeof(global::AppStoreConnect.Build),
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
        public bool Equals(IncludedItem57 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaTester?>.Default.Equals(BetaTesters, other.BetaTesters) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem57 obj1, IncludedItem57 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem57>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem57 obj1, IncludedItem57 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem57 o && Equals(o);
        }
    }
}
