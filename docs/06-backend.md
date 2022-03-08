# Backend Implementation

We have a simple backend built using .net core and implements both the endpoints that we agreed on in our schema design. In addition we also defined a postman environment for our developers to use.

Here are the things that we did.

1. Implement the endpoints on the asp.net core project.
2. Created an [environment](../test/contract/weather-api-dev.postman_environment.json) for local dev endpoints.
3. Create a script ```test-contract-dev``` to run postman tests against the local dev api in [package.json](../package.json).

To run the tests - simply run the following:

```bash
yarn test-contract-dev
```
