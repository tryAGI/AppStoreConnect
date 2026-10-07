#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem35 : global::System.IEquatable<IncludedItem35>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreReviewAttachment? AppStoreReviewAttachments { get; init; }
#else
        public global::AppStoreConnect.AppStoreReviewAttachment? AppStoreReviewAttachments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreReviewAttachments))]
#endif
        public bool IsAppStoreReviewAttachments => AppStoreReviewAttachments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreReviewAttachments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreReviewAttachment? value)
        {
            value = AppStoreReviewAttachments;
            return IsAppStoreReviewAttachments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreReviewAttachment PickAppStoreReviewAttachments() => AppStoreReviewAttachments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreReviewAttachments' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions))]
#endif
        public bool IsAppStoreVersions => AppStoreVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions;
            return IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => AppStoreVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem35(global::AppStoreConnect.AppStoreReviewAttachment value) => new IncludedItem35((global::AppStoreConnect.AppStoreReviewAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreReviewAttachment?(IncludedItem35 @this) => @this.AppStoreReviewAttachments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem35(global::AppStoreConnect.AppStoreReviewAttachment? value)
        {
            AppStoreReviewAttachments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem35 FromAppStoreReviewAttachments(global::AppStoreConnect.AppStoreReviewAttachment? value) => new IncludedItem35(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem35(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem35((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem35 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem35(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem35 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem35(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem35(
            global::AppStoreConnect.AppStoreReviewDetailResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreReviewAttachment? appStoreReviewAttachments,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions
            )
        {
            Type = type;

            AppStoreReviewAttachments = appStoreReviewAttachments;
            AppStoreVersions = appStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersions as object ??
            AppStoreReviewAttachments as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreReviewAttachments?.ToString() ??
            AppStoreVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreReviewAttachments && !IsAppStoreVersions || !IsAppStoreReviewAttachments && IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreReviewAttachment, TResult>? appStoreReviewAttachments = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreReviewAttachments is { } __value0 && appStoreReviewAttachments != null)
            {
                return appStoreReviewAttachments(__value0);
            }
            else if (AppStoreVersions is { } __value1 && appStoreVersions != null)
            {
                return appStoreVersions(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreReviewAttachment>? appStoreReviewAttachments = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreReviewAttachments is { } __value0)
            {
                appStoreReviewAttachments?.Invoke(__value0);
            }
            else if (AppStoreVersions is { } __value1)
            {
                appStoreVersions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreReviewAttachment>? appStoreReviewAttachments = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreReviewAttachments is { } __value0)
            {
                appStoreReviewAttachments?.Invoke(__value0);
            }
            else if (AppStoreVersions is { } __value1)
            {
                appStoreVersions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreReviewAttachments,
                typeof(global::AppStoreConnect.AppStoreReviewAttachment),
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
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
        public bool Equals(IncludedItem35 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreReviewAttachment?>.Default.Equals(AppStoreReviewAttachments, other.AppStoreReviewAttachments) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem35 obj1, IncludedItem35 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem35>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem35 obj1, IncludedItem35 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem35 o && Equals(o);
        }
    }
}
