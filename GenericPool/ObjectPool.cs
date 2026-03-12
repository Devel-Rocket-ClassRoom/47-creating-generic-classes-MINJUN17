using System;
using System.Collections.Generic;
using System.Text;

class ObjectPool<T> where T : class, IPoolable, new()
{
    private List<T> _available;
    private List<T> _active;
    private int _maxSize;
    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
        _active = new List<T>();
        _available = new List<T>();
    }
    public T Get()
    {
        if (_available.Count > 0)
        {
            T item = _available[0];
            _available.RemoveAt(0);
            _active.Add(item);
            return item;
        }
        else if (_available.Count + _active.Count < _maxSize)
        {
            T item = new T();
            _active.Add(item);
            return item;
        }
        else
        {
            return null;
        }
    }
}