
public class BubbleSort<T> : SortAlgorithmBase<T> where T: IComparable
{
    public BubbleSort(IList<T> collection) : base(collection) { }

    public override void Sort()
    {
        for (int i = 0; i < Collection.Count - 1; i++)
        {
            for (int j = 0; j < Collection.Count - 1 - i; j++)
            {
                if (Collection[j].CompareTo(Collection[j + 1]) > 0)
                {
                    T temp = Collection[j + 1];
                    Collection[j + 1] = Collection[j];
                    Collection[j] = temp;
                }
            }
        }
    }
}