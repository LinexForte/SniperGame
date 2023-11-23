public interface IHealthChangedObservable
{
    void Subscribe(IHealthChangedObserver listener);
    void Unsubscribe(IHealthChangedObserver listener);
}
