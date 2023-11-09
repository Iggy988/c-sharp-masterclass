

public interface IObserver<TData>
{
    void Update(TData data);    
}

public interface IObservable<TData>
{
    void AttachObserver(IObserver<TData> observer);
    void DetachObserver(IObserver<TData> observer);
    void NotifyObservers();
}