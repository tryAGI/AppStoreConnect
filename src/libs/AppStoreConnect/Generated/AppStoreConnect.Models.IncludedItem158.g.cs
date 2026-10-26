#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem158 : global::System.IEquatable<IncludedItem158>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.Actor PickActors() => Actors is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Actors' but the value was {ToString()}.");

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

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
        public global::AppStoreConnect.ReviewSubmissionItem PickReviewSubmissionItems() => ReviewSubmissionItems is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewSubmissionItems' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.Actor value) => new IncludedItem158((global::AppStoreConnect.Actor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Actor?(IncludedItem158 @this) => @this.Actors;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.Actor? value)
        {
            Actors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem158 FromActors(global::AppStoreConnect.Actor? value) => new IncludedItem158(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem158((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem158 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem158 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem158(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.App value) => new IncludedItem158((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem158 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem158 FromApps(global::AppStoreConnect.App? value) => new IncludedItem158(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem158(global::AppStoreConnect.ReviewSubmissionItem value) => new IncludedItem158((global::AppStoreConnect.ReviewSubmissionItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.ReviewSubmissionItem?(IncludedItem158 @this) => @this.ReviewSubmissionItems;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem158(global::AppStoreConnect.ReviewSubmissionItem? value)
        {
            ReviewSubmissionItems = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem158 FromReviewSubmissionItems(global::AppStoreConnect.ReviewSubmissionItem? value) => new IncludedItem158(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem158(
            global::AppStoreConnect.ReviewSubmissionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.Actor? actors,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.ReviewSubmissionItem? reviewSubmissionItems
            )
        {
            Type = type;

            Actors = actors;
            AppStoreVersions = appStoreVersions;
            Apps = apps;
            ReviewSubmissionItems = reviewSubmissionItems;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReviewSubmissionItems as object ??
            Apps as object ??
            AppStoreVersions as object ??
            Actors as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Actors?.ToString() ??
            AppStoreVersions?.ToString() ??
            Apps?.ToString() ??
            ReviewSubmissionItems?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActors && !IsAppStoreVersions && !IsApps && !IsReviewSubmissionItems || !IsActors && IsAppStoreVersions && !IsApps && !IsReviewSubmissionItems || !IsActors && !IsAppStoreVersions && IsApps && !IsReviewSubmissionItems || !IsActors && !IsAppStoreVersions && !IsApps && IsReviewSubmissionItems;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.Actor, TResult>? actors = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.ReviewSubmissionItem, TResult>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0 && actors != null)
            {
                return actors(__value0);
            }
            else if (AppStoreVersions is { } __value1 && appStoreVersions != null)
            {
                return appStoreVersions(__value1);
            }
            else if (Apps is { } __value2 && apps != null)
            {
                return apps(__value2);
            }
            else if (ReviewSubmissionItems is { } __value3 && reviewSubmissionItems != null)
            {
                return reviewSubmissionItems(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.ReviewSubmissionItem>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0)
            {
                actors?.Invoke(__value0);
            }
            else if (AppStoreVersions is { } __value1)
            {
                appStoreVersions?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
            else if (ReviewSubmissionItems is { } __value3)
            {
                reviewSubmissionItems?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.ReviewSubmissionItem>? reviewSubmissionItems = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0)
            {
                actors?.Invoke(__value0);
            }
            else if (AppStoreVersions is { } __value1)
            {
                appStoreVersions?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
            else if (ReviewSubmissionItems is { } __value3)
            {
                reviewSubmissionItems?.Invoke(__value3);
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
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
                Apps,
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
        public bool Equals(IncludedItem158 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Actor?>.Default.Equals(Actors, other.Actors) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ReviewSubmissionItem?>.Default.Equals(ReviewSubmissionItems, other.ReviewSubmissionItems)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem158 obj1, IncludedItem158 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem158>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem158 obj1, IncludedItem158 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem158 o && Equals(o);
        }
    }
}
