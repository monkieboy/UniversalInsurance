(*#r @"packages/FAKE/tools/FakeLib.dll" *)
open Fake

RestorePackages()

let buildDir = "./build/"
let testDir = "./test/"
let testDlls = !!"./test/*Tests.dll"

Target "Clean" (fun _ -> CleanDir buildDir)
Target "Build" (fun _ -> 
    !! "src/**/*.csproj" 
    |> MSBuildRelease buildDir "Build" 
    |> Log "BuildOutput: ")

Target "BuildTests" (fun _ -> 
    !! "src/**/*Tests.csproj" 
    |> MSBuildDebug testDir "Build" |> Log "TestBuild-Output: ")

Target "RunTests" (fun _ -> 
    testDlls
      |> NUnit (fun p ->
          {p with
             DisableShadowCopy = true;
             OutputFile = testDir + "TestResults.xml" })
)

Target "FinishBuild" (fun _ -> trace "Build Script Fininshed")

"Clean"
    ==> "Build"
    ==> "BuildTests"
    ==> "RunTests"
    ==> "FinishBuild"

RunTargetOrDefault "FinishBuild"
