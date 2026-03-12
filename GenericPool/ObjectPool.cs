using System;
using System.Collections.Generic;
using System.Text;

class ObjectPool<T> where T: class, IPoolable, new()
{
    private List<T> _available;
    private List<T> _active;
    public ObjectPool(int maxSize)
    {
        
    }
}
