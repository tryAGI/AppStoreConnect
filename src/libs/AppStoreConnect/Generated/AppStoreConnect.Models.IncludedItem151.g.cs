#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem151 : global::System.IEquatable<IncludedItem151>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BundleId? BundleIds { get; init; }
#else
        public global::AppStoreConnect.BundleId? BundleIds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BundleIds))]
#endif
        public bool IsBundleIds => BundleIds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBundleIds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BundleId? value)
        {
            value = BundleIds;
            return IsBundleIds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BundleId PickBundleIds() => IsBundleIds
            ? BundleIds!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BundleIds' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Certificate? Certificates { get; init; }
#else
        public global::AppStoreConnect.Certificate? Certificates { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Certificates))]
#endif
        public bool IsCertificates => Certificates != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCertificates(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Certificate? value)
        {
            value = Certificates;
            return IsCertificates;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Certificate PickCertificates() => IsCertificates
            ? Certificates!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Certificates' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Device? Devices { get; init; }
#else
        public global::AppStoreConnect.Device? Devices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Devices))]
#endif
        public bool IsDevices => Devices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDevices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Device? value)
        {
            value = Devices;
            return IsDevices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Device PickDevices() => IsDevices
            ? Devices!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Devices' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem151(global::AppStoreConnect.BundleId value) => new IncludedItem151((global::AppStoreConnect.BundleId?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BundleId?(IncludedItem151 @this) => @this.BundleIds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem151(global::AppStoreConnect.BundleId? value)
        {
            BundleIds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem151 FromBundleIds(global::AppStoreConnect.BundleId? value) => new IncludedItem151(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem151(global::AppStoreConnect.Certificate value) => new IncludedItem151((global::AppStoreConnect.Certificate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Certificate?(IncludedItem151 @this) => @this.Certificates;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem151(global::AppStoreConnect.Certificate? value)
        {
            Certificates = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem151 FromCertificates(global::AppStoreConnect.Certificate? value) => new IncludedItem151(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem151(global::AppStoreConnect.Device value) => new IncludedItem151((global::AppStoreConnect.Device?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Device?(IncludedItem151 @this) => @this.Devices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem151(global::AppStoreConnect.Device? value)
        {
            Devices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem151 FromDevices(global::AppStoreConnect.Device? value) => new IncludedItem151(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem151(
            global::AppStoreConnect.ProfileResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.BundleId? bundleIds,
            global::AppStoreConnect.Certificate? certificates,
            global::AppStoreConnect.Device? devices
            )
        {
            Type = type;

            BundleIds = bundleIds;
            Certificates = certificates;
            Devices = devices;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Devices as object ??
            Certificates as object ??
            BundleIds as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BundleIds?.ToString() ??
            Certificates?.ToString() ??
            Devices?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBundleIds && !IsCertificates && !IsDevices || !IsBundleIds && IsCertificates && !IsDevices || !IsBundleIds && !IsCertificates && IsDevices;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.BundleId, TResult>? bundleIds = null,
            global::System.Func<global::AppStoreConnect.Certificate, TResult>? certificates = null,
            global::System.Func<global::AppStoreConnect.Device, TResult>? devices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBundleIds && bundleIds != null)
            {
                return bundleIds(BundleIds!);
            }
            else if (IsCertificates && certificates != null)
            {
                return certificates(Certificates!);
            }
            else if (IsDevices && devices != null)
            {
                return devices(Devices!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.BundleId>? bundleIds = null,

            global::System.Action<global::AppStoreConnect.Certificate>? certificates = null,

            global::System.Action<global::AppStoreConnect.Device>? devices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBundleIds)
            {
                bundleIds?.Invoke(BundleIds!);
            }
            else if (IsCertificates)
            {
                certificates?.Invoke(Certificates!);
            }
            else if (IsDevices)
            {
                devices?.Invoke(Devices!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.BundleId>? bundleIds = null,
            global::System.Action<global::AppStoreConnect.Certificate>? certificates = null,
            global::System.Action<global::AppStoreConnect.Device>? devices = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBundleIds)
            {
                bundleIds?.Invoke(BundleIds!);
            }
            else if (IsCertificates)
            {
                certificates?.Invoke(Certificates!);
            }
            else if (IsDevices)
            {
                devices?.Invoke(Devices!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BundleIds,
                typeof(global::AppStoreConnect.BundleId),
                Certificates,
                typeof(global::AppStoreConnect.Certificate),
                Devices,
                typeof(global::AppStoreConnect.Device),
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
        public bool Equals(IncludedItem151 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BundleId?>.Default.Equals(BundleIds, other.BundleIds) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Certificate?>.Default.Equals(Certificates, other.Certificates) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Device?>.Default.Equals(Devices, other.Devices)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem151 obj1, IncludedItem151 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem151>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem151 obj1, IncludedItem151 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem151 o && Equals(o);
        }
    }
}
