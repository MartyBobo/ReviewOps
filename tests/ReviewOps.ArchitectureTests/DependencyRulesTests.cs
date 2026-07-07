using NetArchTest.Rules;
using Shouldly;

namespace ReviewOps.ArchitectureTests;

public sealed class DependencyRulesTests
{
    [Fact]
    public void DomainShouldNotDependOnOtherProjectLayers()
    {
        string[] forbiddenNamespaces =
        [
            "ReviewOps.Application",
            "ReviewOps.Infrastructure",
            "ReviewOps.Api",
            "ReviewOps.Worker",
        ];

        var result = Types.FromFile(AssemblyPath("ReviewOps.Domain.dll"))
            .ShouldNot()
            .HaveDependencyOnAny(forbiddenNamespaces)
            .GetResult();

        result.IsSuccessful.ShouldBeTrue();
    }

    [Fact]
    public void ApplicationShouldNotDependOnInfrastructureApiOrWorker()
    {
        string[] forbiddenNamespaces =
        [
            "ReviewOps.Infrastructure",
            "ReviewOps.Api",
            "ReviewOps.Worker",
        ];

        var result = Types.FromFile(AssemblyPath("ReviewOps.Application.dll"))
            .ShouldNot()
            .HaveDependencyOnAny(forbiddenNamespaces)
            .GetResult();

        result.IsSuccessful.ShouldBeTrue();
    }

    private static string AssemblyPath(string assemblyFileName)
    {
        return Path.Combine(AppContext.BaseDirectory, assemblyFileName);
    }
}
