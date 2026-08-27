#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem157 : global::System.IEquatable<IncludedItem157>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Actor? Actors { get; init; }
#else
        public global::AppStoreConnect.Actor? Actors { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Actors))]
#endif
        public bool IsActors => Actors != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickActors(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Actor? value)
        {
            value = Actors;
            return IsActors;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.Actor PickActors() => IsActors
            ? Actors!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Actors' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions1 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions1))]
#endif
        public bool IsAppStoreVersions1 => AppStoreVersions1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppStoreVersions1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions1;
            return IsAppStoreVersions1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions1() => IsAppStoreVersions1
            ? AppStoreVersions1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppStoreVersions2 { get; init; }
#else
        public global::AppStoreConnect.App? AppStoreVersions2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions2))]
#endif
        public bool IsAppStoreVersions2 => AppStoreVersions2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppStoreVersions2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppStoreVersions2;
            return IsAppStoreVersions2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickAppStoreVersions2() => IsAppStoreVersions2
            ? AppStoreVersions2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.ReviewSubmissionItem? ReviewSubmissionItems { get; init; }
#else
        public global::AppStoreConnect.ReviewSubmissionItem? ReviewSubmissionItems { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewSubmissionItems))]
#endif
        public bool IsReviewSubmissionItems => ReviewSubmissionItems != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReviewSubmissionItems(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ReviewSubmissionItem? value)
        {
            value = ReviewSubmissionItems;
            return IsReviewSubmissionItems;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.ReviewSubmissionItem PickReviewSubmissionItems() => IsReviewSubmissionItems
            ? ReviewSubmissionItems!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewSubmissionItems' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem157(global::AppStoreConnect.Actor value) => new IncludedItem157((global::AppStoreConnect.Actor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Actor?(IncludedItem157 @this) => @this.Actors;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem157(global::AppStoreConnect.Actor? value)
        {
            Actors = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem157 FromActors(global::AppStoreConnect.Actor? value) => new IncludedItem157(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem157(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem157((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem157 @this) => @this.AppStoreVersions1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem157(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem157 FromAppStoreVersions1(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem157(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem157(global::AppStoreConnect.App value) => new IncludedItem157((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem157 @this) => @this.AppStoreVersions2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem157(global::AppStoreConnect.App? value)
        {
            AppStoreVersions2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem157 FromAppStoreVersions2(global::AppStoreConnect.App? value) => new IncludedItem157(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem157(global::AppStoreConnect.ReviewSubmissionItem value) => new IncludedItem157((global::AppStoreConnect.ReviewSubmissionItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.ReviewSubmissionItem?(IncludedItem157 @this) => @this.ReviewSubmissionItems;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem157(global::AppStoreConnect.ReviewSubmissionItem? value)
        {
            ReviewSubmissionItems = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem157 FromReviewSubmissionItems(global::AppStoreConnect.ReviewSubmissionItem? value) => new IncludedItem157(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem157(
            global::AppStoreConnect.ReviewSubmissionResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.Actor? actors,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions1,
            global::AppStoreConnect.App? appStoreVersions2,
            global::AppStoreConnect.ReviewSubmissionItem? reviewSubmissionItems
            )
        {
            Type = type;

            Actors = actors;
            AppStoreVersions1 = appStoreVersions1;
            AppStoreVersions2 = appStoreVersions2;
            ReviewSubmissionItems = reviewSubmissionItems;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReviewSubmissionItems as object ??
            AppStoreVersions2 as object ??
            AppStoreVersions1 as object ??
            Actors as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Actors?.ToString() ??
            AppStoreVersions1?.ToString() ??
            AppStoreVersions2?.ToString() ??
            ReviewSubmissionItems?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsActors && !IsAppStoreVersions1 && !IsAppStoreVersions2 && !IsReviewSubmissionItems || !IsActors && IsAppStoreVersions1 && !IsAppStoreVersions2 && !IsReviewSubmissionItems || !IsActors && !IsAppStoreVersions1 && IsAppStoreVersions2 && !IsReviewSubmissionItems || !IsActors && !IsAppStoreVersions1 && !IsAppStoreVersions2 && IsReviewSubmissionItems;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.Actor, TResult>? actors = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions1 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appStoreVersions2 = null,
            global::System.Func<global::AppStoreConnect.ReviewSubmissionItem, TResult>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors && actors != null)
            {
                return actors(Actors!);
            }
            else if (IsAppStoreVersions1 && appStoreVersions1 != null)
            {
                return appStoreVersions1(AppStoreVersions1!);
            }
            else if (IsAppStoreVersions2 && appStoreVersions2 != null)
            {
                return appStoreVersions2(AppStoreVersions2!);
            }
            else if (IsReviewSubmissionItems && reviewSubmissionItems != null)
            {
                return reviewSubmissionItems(ReviewSubmissionItems!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions1 = null,

            global::System.Action<global::AppStoreConnect.App>? appStoreVersions2 = null,

            global::System.Action<global::AppStoreConnect.ReviewSubmissionItem>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors)
            {
                actors?.Invoke(Actors!);
            }
            else if (IsAppStoreVersions1)
            {
                appStoreVersions1?.Invoke(AppStoreVersions1!);
            }
            else if (IsAppStoreVersions2)
            {
                appStoreVersions2?.Invoke(AppStoreVersions2!);
            }
            else if (IsReviewSubmissionItems)
            {
                reviewSubmissionItems?.Invoke(ReviewSubmissionItems!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions1 = null,
            global::System.Action<global::AppStoreConnect.App>? appStoreVersions2 = null,
            global::System.Action<global::AppStoreConnect.ReviewSubmissionItem>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors)
            {
                actors?.Invoke(Actors!);
            }
            else if (IsAppStoreVersions1)
            {
                appStoreVersions1?.Invoke(AppStoreVersions1!);
            }
            else if (IsAppStoreVersions2)
            {
                appStoreVersions2?.Invoke(AppStoreVersions2!);
            }
            else if (IsReviewSubmissionItems)
            {
                reviewSubmissionItems?.Invoke(ReviewSubmissionItems!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Actors,
                typeof(global::AppStoreConnect.Actor),
                AppStoreVersions1,
                typeof(global::AppStoreConnect.AppStoreVersion),
                AppStoreVersions2,
                typeof(global::AppStoreConnect.App),
                ReviewSubmissionItems,
                typeof(global::AppStoreConnect.ReviewSubmissionItem),
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
        public bool Equals(IncludedItem157 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Actor?>.Default.Equals(Actors, other.Actors) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions1, other.AppStoreVersions1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppStoreVersions2, other.AppStoreVersions2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ReviewSubmissionItem?>.Default.Equals(ReviewSubmissionItems, other.ReviewSubmissionItems) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem157 obj1, IncludedItem157 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem157>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem157 obj1, IncludedItem157 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem157 o && Equals(o);
        }
    }
}
