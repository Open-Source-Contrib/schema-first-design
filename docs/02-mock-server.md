# Mock Server

Now that we have the API design and schema - let's create a mock server that we can spin up. For this example we will be using [Prism](https://meta.stoplight.io/docs/prism/ZG9jOjky-installation). Prism is also available as a docker image so we will be using the docker image - other ways include installing the CLI on your dev machine. Given that docker today is ubiquitous on most development machines - this is what we will be using for this example.

## How does the mock server work?

The mock server works by taking in a schema definition (in our case a openapi V3 definition file.). The mock server looks at our API definition and then based on the constraints defined there and using the examples provided in the API - responds to incoming requests.

### Setup

For this workshop we are using the [Prism](https://meta.stoplight.io/docs/prism/ZG9jOjky-installation) mock server. The step by step guide is available on their website. It's open source tool so the barrier to entry is really low - however you are free choose any other similar tool.

1. Create a [docker-compose.yaml](../specs/docker-compose.yaml).
2. Define the image for the mock server service.
3. Map your [bundled openapi.yaml](../specs/.outputs/openapi.yaml) inside the container as a volume.
4. Define a host system ```port``` mapping to mock server port ```4010``` running inside the container.
5. Add script in [package.json](../package.json) file to start the mock server.
