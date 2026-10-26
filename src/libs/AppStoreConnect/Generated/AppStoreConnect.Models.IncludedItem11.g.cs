#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem11 : global::System.IEquatable<IncludedItem11>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences { get; init; }
#else
        public global::AppStoreConnect.AppClipDefaultExperience? AppClipDefaultExperiences { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipDefaultExperiences))]
#endif
        public bool IsAppClipDefaultExperiences => AppClipDefaultExperiences != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipDefaultExperiences(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            value = AppClipDefaultExperiences;
            return IsAppClipDefaultExperiences;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipDefaultExperience PickAppClipDefaultExperiences() => AppClipDefaultExperiences is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipDefaultExperiences' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem11(global::AppStoreConnect.AppClipDefaultExperience value) => new IncludedItem11((global::AppStoreConnect.AppClipDefaultExperience?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipDefaultExperience?(IncludedItem11 @this) => @this.AppClipDefaultExperiences;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.AppClipDefaultExperience? value)
        {
            AppClipDefaultExperiences = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromAppClipDefaultExperiences(global::AppStoreConnect.AppClipDefaultExperience? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem11(global::AppStoreConnect.App value) => new IncludedItem11((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem11 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromApps(global::AppStoreConnect.App? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(
            global::AppStoreConnect.AppClipsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipDefaultExperience? appClipDefaultExperiences,
            global::AppStoreConnect.App? apps
            )
        {
            Type = type;

            AppClipDefaultExperiences = appClipDefaultExperiences;
            Apps = apps;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Apps as object ??
            AppClipDefaultExperiences as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppClipDefaultExperiences?.ToString() ??
            Apps?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppClipDefaultExperiences && !IsApps || !IsAppClipDefaultExperiences && IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipDefaultExperience, TResult>? appClipDefaultExperiences = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipDefaultExperiences is { } __value0 && appClipDefaultExperiences != null)
            {
                return appClipDefaultExperiences(__value0);
            }
            else if (Apps is { } __value1 && apps != null)
            {
                return apps(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipDefaultExperiences is { } __value0)
            {
                appClipDefaultExperiences?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipDefaultExperience>? appClipDefaultExperiences = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipDefaultExperiences is { } __value0)
            {
                appClipDefaultExperiences?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipDefaultExperiences,
                typeof(global::AppStoreConnect.AppClipDefaultExperience),
                Apps,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem11 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipDefaultExperience?>.Default.Equals(AppClipDefaultExperiences, other.AppClipDefaultExperiences) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem11 obj1, IncludedItem11 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem11>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem11 obj1, IncludedItem11 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem11 o && Equals(o);
        }
    }
}
