namespace SmartEnumExperiment.NatchOS
{
    using Ardalis.SmartEnum;

    public class PersonEvent : SmartEnum<PersonEvent>
    {
        public static readonly PersonEvent NotSet = new PersonEvent(nameof(NotSet), 0);
        public static readonly PersonEvent LastPasswordChangeUtcTimestamp = new PersonEvent(nameof(LastPasswordChangeUtcTimestamp), 1);
        public static readonly PersonEvent LastLockoutUtcTimestamp = new PersonEvent(nameof(LastLockoutUtcTimestamp), 2);
        public static readonly PersonEvent FailedPasswordAttemptCount = new PersonEvent(nameof(FailedPasswordAttemptCount), 3);
        public static readonly PersonEvent FailedPasswordAttemptWindowStart = new PersonEvent(nameof(FailedPasswordAttemptWindowStart), 4);
        public static readonly PersonEvent LastActivationMailSentUtcTimestamp = new PersonEvent(nameof(LastActivationMailSentUtcTimestamp), 5);
        public static readonly PersonEvent LastProductSearchUtcTimestamp = new PersonEvent(nameof(LastProductSearchUtcTimestamp), 6);
        public static readonly PersonEvent ProductSearchCount = new PersonEvent(nameof(ProductSearchCount), 7);
        public static readonly PersonEvent LastActivityUtcTimestamp = new PersonEvent(nameof(LastActivityUtcTimestamp), 8);
        public static readonly PersonEvent LastStoreAccessNotificationSentUtcTimestamp = new PersonEvent(nameof(LastStoreAccessNotificationSentUtcTimestamp), 9);
        public static readonly PersonEvent FirstLoginUtcTimestamp = new PersonEvent(nameof(FirstLoginUtcTimestamp), 10);
        public static readonly PersonEvent LastBasketSubmitUtcTimestamp = new PersonEvent(nameof(LastBasketSubmitUtcTimestamp), 11);
        public static readonly PersonEvent LastDocumentSearchUtcTimestamp = new PersonEvent(nameof(LastDocumentSearchUtcTimestamp), 12);
        public static readonly PersonEvent DocumentSearchCount = new PersonEvent(nameof(DocumentSearchCount), 13);
        public static readonly PersonEvent ActivityScore = new PersonEvent(nameof(ActivityScore), 14);

        protected PersonEvent(string name, int value) : base(name, value)
        {
        }
    }
}
