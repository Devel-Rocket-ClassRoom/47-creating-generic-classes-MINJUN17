using System;
using System.Collections.Generic;
using System.Text;

class SimpleQueue<T>
{
    private T[] _items;
    private int _count = 0;
    public int Count => _count;
    public bool IsEmpty => _count == 0;
    public bool IsFull => _count == _items.Length;

    public SimpleQueue(int capacity)
    {
        _items = new T[capacity];
    }
    public void Enqueue(T item)
    {
        if( _count >= _items.Length)
        {
            Console.WriteLine("큐가 가득 찼습니다.");
            return;
        }
        _items[_count++] = item;
    }
    public T Dequeue()
    {
        if(_count <= 0)
        {
            Console.WriteLine("큐가 비어있습니다");
            return default;
        }
        T temp = default;
        for(int i = 0; i < _count; i++)
        {
            if(i == 0)
            {
                temp = _items[i];
            }
            else
            {
                _items[i - 1] = _items[i];
            }
        }
        _count--;
        return temp;
    }
    public T Peek()
    {
        if (_count <= 0)
        {
            Console.WriteLine("큐가 비어있습니다");
            return default;
        }
        return _items[0];
    }

}
