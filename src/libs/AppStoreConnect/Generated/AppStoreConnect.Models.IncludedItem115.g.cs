#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem115 : global::System.IEquatable<IncludedItem115>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment? AppStoreVersionExperimentTreatments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatments))]
#endif
        public bool IsAppStoreVersionExperimentTreatments => AppStoreVersionExperimentTreatments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            value = AppStoreVersionExperimentTreatments;
            return IsAppStoreVersionExperimentTreatments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatment PickAppStoreVersionExperimentTreatments() => AppStoreVersionExperimentTreatments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatments' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem115(global::AppStoreConnect.AppStoreVersionExperimentTreatment value) => new IncludedItem115((global::AppStoreConnect.AppStoreVersionExperimentTreatment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatment?(IncludedItem115 @this) => @this.AppStoreVersionExperimentTreatments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value)
        {
            AppStoreVersionExperimentTreatments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem115 FromAppStoreVersionExperimentTreatments(global::AppStoreConnect.AppStoreVersionExperimentTreatment? value) => new IncludedItem115(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem115(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem115((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem115 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem115 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem115(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(
            global::AppStoreConnect.AppStoreVersionExperimentResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatments,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions
            )
        {
            Type = type;

            AppStoreVersionExperimentTreatments = appStoreVersionExperimentTreatments;
            AppStoreVersions = appStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersions as object ??
            AppStoreVersionExperimentTreatments as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersionExperimentTreatments?.ToString() ??
            AppStoreVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersionExperimentTreatments && !IsAppStoreVersions || !IsAppStoreVersionExperimentTreatments && IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatment, TResult>? appStoreVersionExperimentTreatments = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatments is { } __value0 && appStoreVersionExperimentTreatments != null)
            {
                return appStoreVersionExperimentTreatments(__value0);
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
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatments is { } __value0)
            {
                appStoreVersionExperimentTreatments?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatment>? appStoreVersionExperimentTreatments = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatments is { } __value0)
            {
                appStoreVersionExperimentTreatments?.Invoke(__value0);
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
                AppStoreVersionExperimentTreatments,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment),
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
        public bool Equals(IncludedItem115 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatment?>.Default.Equals(AppStoreVersionExperimentTreatments, other.AppStoreVersionExperimentTreatments) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem115 obj1, IncludedItem115 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem115>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem115 obj1, IncludedItem115 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem115 o && Equals(o);
        }
    }
}
