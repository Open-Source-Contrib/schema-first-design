# Schema Test

We can use any tool to write schema tests, for the sake of this example I am using the poor man's tool - postman.

Here are the steps that need to be followed.

1. Add ```newman``` as a dependency to [package.json](../package.json) (ex: ```yarn add -D newman``` or ```npm i -d newman```).
2. Create postman collection with schema tests (this is intentionally left out) - you are free to look at the example [collection](../test/contract/weather-api.postman_collection.json) & [environment](../test/contract/weather-api-local.postman_environment.json) in this repo.
3. Add a script to [package.json](../package.json) to run the tests against the mock server. Example see ```test-contract-mock```.

You don't have to use the postman (this is not a postman demo) - the idea here is to present a concept which **Contract Testing** before the actual implementation and then running the test suite first against the mock server and then later against the implemented server.

## Suggested Practices

1. Contract tests are not for testing your app/business logic
2. They are to make sure that you don't break the public contract on which your API consumers depend.
3. When you get your first consumer for API - treat your API schema like something set in stone and sacred, it should never be changed - if you need to add something create a new version.
4. It's always helpful to modularize your tests to separate the environment specific variables to a separate place so that you can run the same tests against multiple environments. Here we did that by specifying the host name in an [environment file](../test/contract/weather-api-local.postman_environment.json).
