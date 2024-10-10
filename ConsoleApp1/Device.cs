namespace ConsoleApp1;

public class Device
{
    public Device(string version, List<Device> children)
    {
        Version = version;
        Children = children;
    }

    public List<Device> Children { get; }

    // v1. ориганал
    public string Version { get; }

    // v2. развитие
    public string Admin { get; }

    // v3. развитие
    public int Port { get; }

}