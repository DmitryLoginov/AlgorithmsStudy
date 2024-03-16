using System;
using System.Collections;
using System.Collections.Generic;

public class SortAlgorithmBase<T> where T: IComparable
{
    public List<T> collection { get; protected set; }

    public SortAlgorithmBase(List<T> collection)
    {
        this.collection = collection;
    }

    public void Sort()
    {
        collection.Sort();
    }
}