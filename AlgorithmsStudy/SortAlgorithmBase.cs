using System;
using System.Collections;
using System.Collections.Generic;

public abstract class SortAlgorithmBase<T> where T: IComparable
{
    public IList<T> Collection { get; protected set; }

    public SortAlgorithmBase(IList<T> collection)
    {
        Collection = collection;
    }

    public abstract void Sort();
}