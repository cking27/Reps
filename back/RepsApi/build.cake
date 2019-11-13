#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#addin "Cake.Docker"
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

var configuration = Argument("configuration", "Release");

var buildDir = Directory("./src/Reps/bin") + Directory(configuration);


Task("Default")
.IsDependentOn("Build")
  .Does(() =>
{
  Information("Hello World!");
});

Task("RunDocker")
.IsDependentOn("Docker-Build")
.IsDependentOn("Docker-Run");


Task("Build").Does(() => {
    Information("Building project...");
    DotNetCoreBuild("./src/RepsApi.csproj");
}).OnError(ex => {
    Error("Build Failed, throwing exception...");
    throw ex;
});


Task("Docker-Build")
.Does(() => {
    var settings = new DockerImageBuildSettings { Tag = new[] {"dockerapp:latest" }};
    DockerBuild(settings, "./docker");
});

Task("Docker-Run")
.Does(() => {
    DockerRun("dockerapp",null,null);
});

Task("RunApi")
.IsDependentOn("Build") 
.Does(() => {
    DotNetCoreRun("./src/RepsApi.csproj");
});

RunTarget(target);