#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem38 : global::System.IEquatable<IncludedItem38>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatmentLocalizations))]
#endif
        public bool IsAppStoreVersionExperimentTreatmentLocalizations => AppStoreVersionExperimentTreatmentLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatmentLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            value = AppStoreVersionExperimentTreatmentLocalizations;
            return IsAppStoreVersionExperimentTreatmentLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization PickAppStoreVersionExperimentTreatmentLocalizations() => AppStoreVersionExperimentTreatmentLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatmentLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments))]
#endif
        public bool IsAppStoreVersionExperiments => AppStoreVersionExperiments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            value = AppStoreVersionExperiments;
            return IsAppStoreVersionExperiments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperiment PickAppStoreVersionExperiments() => AppStoreVersionExperiments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem38(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization value) => new IncludedItem38((global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?(IncludedItem38 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem38 FromAppStoreVersionExperimentTreatmentLocalizations(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value) => new IncludedItem38(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem38(global::AppStoreConnect.AppStoreVersionExperiment value) => new IncludedItem38((global::AppStoreConnect.AppStoreVersionExperiment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperiment?(IncludedItem38 @this) => @this.AppStoreVersionExperiments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            AppStoreVersionExperiments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem38 FromAppStoreVersionExperiments(global::AppStoreConnect.AppStoreVersionExperiment? value) => new IncludedItem38(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem38(
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations,
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments
            )
        {
            Type = type;

            AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
            AppStoreVersionExperiments = appStoreVersionExperiments;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionExperiments as object ??
            AppStoreVersionExperimentTreatmentLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersionExperimentTreatmentLocalizations?.ToString() ??
            AppStoreVersionExperiments?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionExperiments || !IsAppStoreVersionExperimentTreatmentLocalizations && IsAppStoreVersionExperiments;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization, TResult>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperiment, TResult>? appStoreVersionExperiments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatmentLocalizations is { } __value0 && appStoreVersionExperimentTreatmentLocalizations != null)
            {
                return appStoreVersionExperimentTreatmentLocalizations(__value0);
            }
            else if (AppStoreVersionExperiments is { } __value1 && appStoreVersionExperiments != null)
            {
                return appStoreVersionExperiments(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatmentLocalizations is { } __value0)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(__value0);
            }
            else if (AppStoreVersionExperiments is { } __value1)
            {
                appStoreVersionExperiments?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersionExperimentTreatmentLocalizations is { } __value0)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(__value0);
            }
            else if (AppStoreVersionExperiments is { } __value1)
            {
                appStoreVersionExperiments?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreVersionExperimentTreatmentLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization),
                AppStoreVersionExperiments,
                typeof(global::AppStoreConnect.AppStoreVersionExperiment),
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
        public bool Equals(IncludedItem38 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations, other.AppStoreVersionExperimentTreatmentLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperiment?>.Default.Equals(AppStoreVersionExperiments, other.AppStoreVersionExperiments)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem38 obj1, IncludedItem38 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem38>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem38 obj1, IncludedItem38 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem38 o && Equals(o);
        }
    }
}
