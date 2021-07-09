namespace SmartEnumExperiment.NatchOS
{
    using System;

    public class EventRegistrar : IEventRegistrar
    {
        public void RegisterEvent(int personId, PersonEvent personEvent, int storeId)
        {
            this.RegisterEvent(personId, personEvent, storeId, null);
        }

        public void RegisterEvent(int personId, PersonEvent personEvent, int storeId, Func<int, PersonEvent, int, StpParameters> customEventHandler)
        {
            switch (personEvent.Name)
            {
                case nameof(PersonEvent.ActivityScore):
                case nameof(PersonEvent.DocumentSearchCount):
                case nameof(PersonEvent.FailedPasswordAttemptCount):
                case nameof(PersonEvent.FailedPasswordAttemptWindowStart):
                case nameof(PersonEvent.FirstLoginUtcTimestamp):
                case nameof(PersonEvent.LastActivationMailSentUtcTimestamp):
                case nameof(PersonEvent.LastActivityUtcTimestamp):
                case nameof(PersonEvent.LastBasketSubmitUtcTimestamp):
                case nameof(PersonEvent.LastDocumentSearchUtcTimestamp):
                case nameof(PersonEvent.LastLockoutUtcTimestamp):
                case nameof(PersonEvent.LastPasswordChangeUtcTimestamp):
                case nameof(PersonEvent.LastProductSearchUtcTimestamp):
                case nameof(PersonEvent.LastStoreAccessNotificationSentUtcTimestamp):
                case nameof(PersonEvent.ProductSearchCount):
                case nameof(PersonEvent.NotSet):
                    Console.WriteLine($"Builtin: {personEvent.Name} = {personEvent.Value}");
                    break;
                default:
                    Console.WriteLine($"Custom: {personEvent.Name} = {personEvent.Value}");
                    if (customEventHandler == null)
                    {
                        throw new ApplicationException($"I don't know how to handle custom PersonEvent {personEvent.Value} - {personEvent.Name}");
                    }

                    var result = customEventHandler(personId, personEvent, storeId);
                    if (result != null)
                    {
                        Console.WriteLine("Custom event was handled");
                        Console.WriteLine($"{result.SystemTypeId} {result.IncrValueAsInt} {result.ValueAsInt} {result.ValueAsUtcDateTime2}");
                    }

                    break;
            }

        }
    }
}
