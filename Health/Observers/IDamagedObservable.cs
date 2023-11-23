public interface IDamagedObservable
{
    void Subscribe(IDamagedObserver listener);
    void Unsubscribe(IDamagedObserver listener);
}
