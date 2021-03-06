module GeneratedEntryPoint

type AutoGeneratedProgram() =
    [<EntryPoint>]
    static let main argv =
        Google.Cloud.Functions.Hosting.EntryPoint.StartAsync(typeof<AutoGeneratedProgram>.Assembly, argv).Result
