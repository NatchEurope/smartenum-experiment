namespace SmartEnumExperiment.Acme
{
    using System;
    using SmartEnumExperiment.NatchOS;

    public class AcmeService
    {
        public void Run()
        {
            var eventRegistrar = new EventRegistrar();

            // Using standard event method 1 - using CustomerPersonEvent smartenum
            var normalEvent1 = CustomPersonEvent.ProductSearchCount;
            eventRegistrar.RegisterEvent(666, normalEvent1, 13);

            // Using standard event method 2 - using natchos version of PersonEvent smartenum
            var normalEvent2 = PersonEvent.ProductSearchCount;
            eventRegistrar.RegisterEvent(666, normalEvent2, 13);

            // Using customer smartenum value
            var customEvent1 = CustomPersonEvent.MyCustomEvent;
            eventRegistrar.RegisterEvent(666, customEvent1, 13, this.HandleCustomPersonEvent);

            var customEvent2 = CustomPersonEvent.AnotherCustomEvent;
            eventRegistrar.RegisterEvent(666, customEvent2, 13, this.HandleCustomPersonEvent);
        }

        public StpParameters HandleCustomPersonEvent(int personId, PersonEvent personEvent, int storeId)
        {
            Console.WriteLine($"Handling custom event {personEvent.Value} - {personEvent.Name}");

            var result = new StpParameters
            {
                IncrValueAsInt = 1,
                SystemTypeId = 56,
                ValueAsUtcDateTime2 = null
            };

            switch (personEvent.Name)
            {
                case nameof(CustomPersonEvent.MyCustomEvent):
                    Console.WriteLine("MyCustomEvent  !!!!!!");
                    result.ValueAsInt = 666;
                    break;
                case nameof(CustomPersonEvent.AnotherCustomEvent):
                    Console.WriteLine("AnotherCustomEvent !!!!!!");
                    result.ValueAsInt = 2021;
                    break;
            }

            return result;
        }
    }
}
