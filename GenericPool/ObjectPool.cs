using System;
using System.Collections.Generic;



public class ObjectPool<T> where T : class, IPoolable, new()
{
    private List<T> _available = new List<T>();
    private List<T> _active = new List<T>();
    private int _maxSize;
    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize;
    }

    public int ActiveCount
    {
        get { return _active.Count; }
    }

    public int AvailableCount
    {
        get { return _available.Count; }
    }
    public T Get()
    {
        T item;
        if (_available.Count > 0)
        {
            item = _available[0];
            _available.RemoveAt(0);
        }
        else
        {
            if (_active.Count + _available.Count >= _maxSize)
            { 
                return null; 
            }
            item = new T();
        }
        _active.Add(item);
        return item;
    }
    public void Return(T item)
    {
        if (_active.Remove(item))
        {
            item.Reset();
            _available.Add(item);
        }
    }
}