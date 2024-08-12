docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli generate \
    -i https://docs.cvr.dev/cvrdev_openapi.yml \
    -g csharp \
    -o /local/