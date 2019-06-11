This sample is to demonstrate a bug with Azure WebJobs SDK (specifically, building an Azure Function) that appears when using both extension bundles (https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-register#local-development-with-azure-functions-core-tools-and-extension-bundles) combined with dependency injection (https://docs.microsoft.com/en-us/azure/azure-functions/functions-dotnet-dependency-injection)

**IMPORTANT:** In order to properly run this sample, you must edit `local.settings.json` and specify a valid connection string for `AzureWebJobsStorage`.

You must then install Azure Functions Core Tools using the instructions here: https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#install-the-azure-functions-core-tools

Then run the following command from the project directory: `func host start`

You will notice that the Startup function is never called since the message `"Startup has been called!"` is never printed.

You can work around the bug simply by removing the `extensionBundle` from `host.json` after running the Azure Function Host for the first time.
