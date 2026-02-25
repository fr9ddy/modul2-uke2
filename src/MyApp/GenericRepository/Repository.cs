using MyApp.GenericCalculator;
using MyApp.GenericRepository;

namespace MyApp.GenericRepository
{
    public class Repository<T> : IRepository<T>
    {
        private List<T>? _items;

        public T Add(T item)
        {
            _items!.Add(item);
            return item;
        }
        public T Remove(T item)
        {
            _items!.Remove(item);
            return item;
        }

        public List<T> GetAll()
        {
            return _items!;
        }

        public T GetByIndex(int index)
        {
            if (index < 0 || index >= _items!.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }

        public bool IsEmpty()
        {
            return _items == null || _items.Count == 0;
        }


        public T[] ToArray()
        {
            return _items!.ToArray();
        }
    }
}