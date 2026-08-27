#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem33 : global::System.IEquatable<IncludedItem33>
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
        public global::AppStoreConnect.AppStoreReviewAttachment PickAppStoreReviewAttachments() => IsAppStoreReviewAttachments
            ? AppStoreReviewAttachments!
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
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => IsAppStoreVersions
            ? AppStoreVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem33(global::AppStoreConnect.AppStoreReviewAttachment value) => new IncludedItem33((global::AppStoreConnect.AppStoreReviewAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreReviewAttachment?(IncludedItem33 @this) => @this.AppStoreReviewAttachments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem33(global::AppStoreConnect.AppStoreReviewAttachment? value)
        {
            AppStoreReviewAttachments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem33 FromAppStoreReviewAttachments(global::AppStoreConnect.AppStoreReviewAttachment? value) => new IncludedItem33(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem33(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem33((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem33 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem33(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem33 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem33(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem33(
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

            if (IsAppStoreReviewAttachments && appStoreReviewAttachments != null)
            {
                return appStoreReviewAttachments(AppStoreReviewAttachments!);
            }
            else if (IsAppStoreVersions && appStoreVersions != null)
            {
                return appStoreVersions(AppStoreVersions!);
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

            if (IsAppStoreReviewAttachments)
            {
                appStoreReviewAttachments?.Invoke(AppStoreReviewAttachments!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
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

            if (IsAppStoreReviewAttachments)
            {
                appStoreReviewAttachments?.Invoke(AppStoreReviewAttachments!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
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
        public bool Equals(IncludedItem33 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreReviewAttachment?>.Default.Equals(AppStoreReviewAttachments, other.AppStoreReviewAttachments) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem33 obj1, IncludedItem33 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem33>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem33 obj1, IncludedItem33 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem33 o && Equals(o);
        }
    }
}
