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

Task("Run")
.IsDependentOn("Build") 
.IsDependentOn("Docker-Build");



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

RunTarget(target);