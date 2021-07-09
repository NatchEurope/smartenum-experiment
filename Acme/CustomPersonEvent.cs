namespace SmartEnumExperiment.Acme
{
    using SmartEnumExperiment.NatchOS;

    public class CustomPersonEvent : PersonEvent
    {
        public static readonly CustomPersonEvent MyCustomEvent = new CustomPersonEvent(nameof(MyCustomEvent), 1000);
        public static readonly CustomPersonEvent AnotherCustomEvent = new CustomPersonEvent(nameof(AnotherCustomEvent), 1001);

        private CustomPersonEvent(string name, int value) : base(name, value)
        {
        }
    }
}
