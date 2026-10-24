# Native App Store Connect uploader

The `src/tools/AppStoreConnect.Uploader` executable uses the generated scoped BuildUploads and BuildUploadFiles clients. It uploads an already signed IPA/PKG without signing, a backend relay, or installing .NET on the consumer host. Linux x64 releases use Native AOT and trimming with reflection disabled and unsuppressed trim diagnostics.

Run `appstoreconnect-upload upload --help`. Credentials come from `APP_STORE_CONNECT_KEY_ID`, `APP_STORE_CONNECT_ISSUER_ID`, and `--private-key-path`. The private journal binds file SHA-256, app/platform/build/version, acknowledged ranges and Apple upload identity. Keep the same journal when retrying. Mutating SDK calls have one attempt; unknown create/commit outcomes are preserved rather than blindly repeated. Upload deadlines bound idle time and the whole command separately. Apple processing and tester distribution require separate verification.

`self-test` makes no network requests and needs no credentials. It exercises generated request/response JSON, range streaming, acknowledgements, accepted journal replay and ambiguous commit reconciliation in the compiled executable. CI runs it on the final native binary before publishing.

The uploader workflow publishes an immutable source-commit release and a compressed binary plus SHA-256/provenance manifest. Consumers must pin and verify the compressed hash before execution, rather than downloading a mutable latest asset. The implementation was ported from the MIT-licensed HavenDV/Advantage upload engine; this SDK repository now owns this standalone tool. Only .NET and the first-party AppStoreConnect SDK are runtime inputs.
