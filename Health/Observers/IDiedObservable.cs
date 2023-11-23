public interface IDiedObservable
{
    void Subscribe(IDiedObserver listener);
    void Unsubscribe(IDiedObserver listener);
}
