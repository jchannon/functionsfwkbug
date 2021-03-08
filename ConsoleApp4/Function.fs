namespace ConsoleApp4

open Google.Cloud.Functions.Framework
open System.Threading.Tasks
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Logging

type Function(logger: ILogger<Function>, config: IConfiguration) =

    do
        logger.LogDebug("Hi from Debug")
        logger.LogInformation("Hi from Info")


    interface IHttpFunction with
        member this.HandleAsync(context) = Task.CompletedTask
