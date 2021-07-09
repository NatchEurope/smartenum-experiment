namespace SmartEnumExperiment.NatchOS
{
    using System;

    public interface IEventRegistrar
    {
        void RegisterEvent(
            int personId,
            PersonEvent personEvent,
            int storeId,
            Func<int, PersonEvent, int, StpParameters> customEventHandler);

        void RegisterEvent(
           int personId,
           PersonEvent personEvent,
           int storeId);
    }
}
