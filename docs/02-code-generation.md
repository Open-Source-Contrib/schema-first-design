# Code Generation

One of the holy grails of **Schema First Design** is to leverage the code generation capabilities that you get when you design the schema for your API. There are several levels to which we can take these code generation capabilities.
1. Generate models & response classes.
2. Generate platform specific API scaffolds ([Controllers](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio) in .Net Core world).
3. Generate/use mock servers to write schema/integrations tests against.
4. Generate/use validation proxies to validate the contracts.
5. Generate multi-language, multi-platform API clients.

In this module we will only focus on the code generation of **models & response classes** for C# and .Net Core. This can be done for any language & platform. You can also customize the generated code based on the style guidelines in your environment - that requires us to build **[mustache](https://mustache.github.io/)** templates.

## Getting started

Here are the preparation steps:

1. You need to have java runtime installed on your system as we are going to use [Swagger tools](https://swagger.io/tools/) which requires java runtime. Don't worry - we will not be building anything in Java - it's just for build toolchain that we are using. Once you have installed Java - you can proceed with the next steps. All of this is setup for you by running the following commands on linux (for windows - it's just easy to download the installers).

```bash
./setup-everything.sh
```

2. Now let's setup our custom build toolchain. To build a workflow I am using yarn & node to be able to define arbitrary scripts that I can run as a group. Please run the following commands in the root of our repo.

```bash
yarn init   # leave everything to default
yarn add -D swagger-nodegen-cli
yarn add -D swagger-cli
```
3. This allows us to now use these pacakges to generate the code for our models.

## Commands

As a rule of thumb we don't check in the generated code in the source control and that is why everything which is generated is added to ```.gitignore```.

I have created a few NPM scripts that can be used to do the following:

1. Validate the Schema: Because schema is a yaml file there could be errors/typos that could prevent us from using the file for generating the code or starting the mock server so you can run the below in the terminal from the root of the repository:

```bash
yarn validate-schema
```

2. Bundle Schema: Incase you have split the schema definition in several files you can bundle them into a single file which can then be fed into the different tools. To do so you can run the below in the terminal from the root of the repository:

```bash
yarn bundle-schema
```

The bundled schema would be available in file [./specs/.outputs/openapi.yaml](../specs/.outputs/openapi.yaml).

3. Generate C# Models: Now we are ready to generate C# models (request/response POCOs) - we can generate the entire shebang of API controllers etc but I don't see a lot value in doing so and also in favor of control over the application design, while you fully customize the generated code for every kind of entity (models, contrllers, clients etc) - for controllers it outweighs the benefits because you would still have to fill in the implementation. For things like models and client libraries it is valuable because you don't have to touch the code once it's generated. Also generated code is not for humans to work with so from that perspective models & clients are good candidates for code generation.
To generate the models simply run the below commands:

```bash
yarn generate-models
```

This would generate the models in the [./src/Model.WeathersInfo.Com/generated_models](./src/Model.WeathersInfo.Com/generated_models) folder. This is a .NET standard library project and it's reference has already been added to our Main API project. This also enables us to ship the models with client as nuget pacakges.
