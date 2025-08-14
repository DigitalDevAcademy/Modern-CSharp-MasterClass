CloudProvider someCloudProvider = new();

Console.WriteLine("-- SaaS --");
someCloudProvider.ProvideSaaS("Web App");

Console.WriteLine("-- SaaS --");
someCloudProvider.ProvideSaaS("Mobile App");

Console.WriteLine("-- PaaS --");
someCloudProvider.ProvidePaaS("Data Management");

Console.WriteLine("-- IaaS --");
someCloudProvider.ProvideIaaS("Lift-And-Shift Migration");

class CloudProvider
{
    public void ProvideSaaS(string config)
    {
        Console.WriteLine($"Providing a {config}");
        ProvidePaaS(config);
    }

    public void ProvidePaaS(string config)
    {
        Console.WriteLine($"Providing a platform for {config}");
        ProvideIaaS(config);
    }

    public void ProvideIaaS(string config)
    {
        Console.WriteLine($"Providing an infra for {config}");
        ProvideHardware();
    }

    private void ProvideHardware()
    {
        Console.WriteLine("Providing hardware");
    }
}