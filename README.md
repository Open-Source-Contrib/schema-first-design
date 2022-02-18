# Schema First Design

This is a POC demonstrating the schema first design which is a variant of [Design by contract](https://en.wikipedia.org/wiki/Design_by_contract) in API design.

So the principal is fairly simple - we first design the API in terms of schema (ie. contract) using some specification - like OpenAPI for REST, there are other schema definition formats like RAML (for REST APIs as well) or SDL for graphQL.
Once the schema is designed - some kind of code generator is used to generate the scaffolded request/response models in specific programming languages, this step can be further extended to generate the API controllers or other language/framework specific abstractions (minus the implementation of course).

Next the schema is ready to be used by a mock server to start the front-end or other systems development while the implementation is filled in. The mock server also allows us to write API schema tests before starting the implementation. This builds such a nice feedback loop.

In parallel another team will be working filling in the implentation of the backend api. Once finished we will route our traffic through the Validation proxy to test entire flow.

Let's say we are building a weather system that can show the weather on a web page, the web page get's the data from an API that we need to build. This is what we are going to build in this workshop. For the sake of focusing on the key concepts here we will return hard coded data from the API response.

Here are the list of technologies that we will be using for building this solution.

|Component          | Tech                                                              |
|:------------------|:-----------------------------------------------------------------:|
|Api Schema         |OpenAPI V3                                                         |
|Code Generator     |[SwaggerCodeGen](https://www.npmjs.com/package/swagger-codegen)    |
|Mock Server        |[prism](https://github.com/stoplightio/prism)                      |
|Validation Proxy   |[prism](https://github.com/stoplightio/prism)                      |
|Schema Tests       |[postman](https://www.postman.com/)                                |
|Front-end          |[reactjs](https://reactjs.org/)                                    |
|Backend            |[.net 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)   |

So in this POC we will be showing the process end to end which will include the following steps.

|S.No   |   Description     |           branch          |
|------:|-------------------|---------------------------|
|0      |Empty-Start Here   |```feature/empty-start```  |
|1      |Design the schema  |```feature/schema```       |
|2      |Code Generation    |```feature/code-gen```     |
|3      |Mock Server        |```feature/mock-server```  |
|4      |Schema Tests       |```feature/schema-tests``` |
|5      |Front-end          |```feature/fe-impl```      |
|6      |Backend            |```feature/be-impl```      |
|7      |Validation Proxy   |```feature/val-proxy```    |

---
## Documentation
For feature specific documents - please visit the below listed links.

|S.No   |   Description     |           branch                     |
|------:|-------------------|--------------------------------------|
|1      |Design the schema  |[doc](./docs/01-design-the-schema.md) |
|2      |Code Generation    |[doc](./docs/02-code-generation.md)   |
|3      |Mock Server        |[doc](./docs/03-mock-server.md)       |
|4      |Schema Tests       |[doc](./docs/04-schema-tests.md)      |
|5      |Front-end          |[doc](./docs/05-front-end.md)         |
|6      |Backend            |[doc](./docs/06-backend.md)           |
|7      |Validation Proxy   |[doc](./docs/07-validation-proxy.md)  |
