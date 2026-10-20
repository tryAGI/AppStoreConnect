#!/usr/bin/env bash
set -euo pipefail

readonly script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$script_dir"

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec) use_pinned_spec=true ;;
    *) echo "Unknown argument: $arg" >&2; exit 1 ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi

readonly autosdk_cli="${AUTOSDK_EXECUTABLE:-autosdk}"
if [[ -z "${AUTOSDK_EXECUTABLE:-}" ]]; then
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 ||
    dotnet tool install --global autosdk.cli --prerelease
fi

if [[ "$use_pinned_spec" == false ]]; then
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
elif [[ ! -f openapi.json ]]; then
  echo "error: --pinned-spec requested but openapi.json does not exist." >&2
  exit 1
fi

rm -rf Generated
"$autosdk_cli" generate openapi.json \
  --namespace AppStoreConnect \
  --clientClassName AppStoreConnectClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --auto-detect-status-polling \
  --security-scheme Http:Header:Bearer \
  --direction-aware-json-generation-mode \
  --json-serializer-context-chunk-size 2000 \
  --shared-json-metadata
