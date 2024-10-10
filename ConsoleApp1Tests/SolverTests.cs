using ConsoleApp1;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ConsoleApp1Tests;

[TestFixture]
public class SolverTests
{
    [Test]
    public void FindDistinctVersionsTest()
    {
        var rootDevice = new Device("0", new List<Device>
        {
            new("2", new List<Device>
            {
                new("3", new List<Device>
                {
                    new("4", new List<Device>())
                })
            }),
            new("3", new List<Device>
            {
                new("1", new List<Device>
                {
                    new("2", new List<Device>
                    {
                        new("5", new List<Device>())
                    })
                })
            })
        });


        var enumerable = new Solver().FindDistinctVersions(rootDevice, device => device.Version);
        Assert.IsNotEmpty(enumerable);
    }

}