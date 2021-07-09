namespace SmartEnumExperiment
{
    using SmartEnumExperiment.Acme;

    class Program
    {
        static void Main(string[] args)
        {
            var service = new AcmeService();
            service.Run();
        }
    }
}
