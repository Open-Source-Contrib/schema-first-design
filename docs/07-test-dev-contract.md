# Testing the Dev Contract

We have already written the schema tests previously, so now we just need to run our tests against the backend that we have built.

Let's do the following to be able to test our backend

1. Add a [postman environment](../test/contract/weather-api-dev.postman_environment.json) file for our dev backend.
2. Add a script to [package.json](../package.json) to run the tests against our dev environment. Example see ```test-contract-dev```.

Hmm so the tests are failing - this is good - the backend guys have not respected the contract and this would mean that our frontend would break.

To verify the frontend - simply run the following command and see if you can spot what is broken.

```bash
yarn start-app:dev
```
