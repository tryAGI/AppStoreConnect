#!/usr/bin/env bash
set -euo pipefail

readonly script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$script_dir"

dotnet tool install --global autosdk.cli --prerelease

readonly spec_url="https://developer.apple.com/sample-code/app-store-connect/app-store-connect-openapi-specification.zip"
readonly temp_dir="$(mktemp -d)"
trap 'rm -rf "$temp_dir"' EXIT

curl --fail --location --retry 3 --output "$temp_dir/spec.zip" "$spec_url"
spec_entry="$(unzip -Z1 "$temp_dir/spec.zip" | awk '/\.json$/ { print; exit }')"
if [[ -z "$spec_entry" ]]; then
  echo "Apple archive does not contain an OpenAPI JSON file." >&2
  exit 1
fi

unzip -p "$temp_dir/spec.zip" "$spec_entry" > openapi.json
rm -rf Generated
autosdk generate openapi.json \
  --namespace AppStoreConnect \
  --clientClassName AppStoreConnectClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --auto-detect-status-polling \
  --security-scheme Http:Header:Bearer
