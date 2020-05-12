using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> data;

    public PriorityQueue()
    {
        this.data = new List<T>();
    }

    public bool IsEmpty()
    {
        if (data == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int ci = data.Count - 1;
        while (ci > 0)
        {
            int pi = (ci - 1) / 2;
            if (data[ci].CompareTo(data[pi]) >= 0)
            {
                break;
            }
            T tmp = data[ci];
            data[ci] = data[pi];
            data[pi] = tmp;
            ci = pi;
        }
    }

    /*public T Dequeue(T item)
    {
        if(IsEmpty() == true)
        {
            int li = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[li];
            data.RemoveAt(li);

            --li;
            int pi = 0;
            while (true)
            {
                int ci = pi * 2 + 1;
                if (ci > li)
                {
                    break;
                }
                int rc = ci + 1;
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0)
                {
                    ci = rc;
                }
                if (data[pi].CompareTo(data[ci]) <= 0)
                {
                    break;
                }
                T tmp = data[pi]; 
                data[pi] = data[ci]; 
                data[ci] = tmp;
                pi = ci;
            }

            return frontItem;
        }
    }*/
}
