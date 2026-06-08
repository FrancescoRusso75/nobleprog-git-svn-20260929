#!/usr/bin/env bash
set -euo pipefail
dotnet publish src/Catalog.Cli -c Release -o out
echo "Pubblicato in ./out"
