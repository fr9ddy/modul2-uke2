using System;

namespace MyApp.GenericCalculator;

public interface IRepository<T>
{
    T Add(T item);
    T Remove(T item);
    List<T> GetAll();
    T[] ToArray();
    T GetByIndex(int index);
    bool IsEmpty();
}
