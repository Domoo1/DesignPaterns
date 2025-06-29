namespace free.src.DesignPatterns.Behavioral.Iterator;
public class ShoppingList
{
    private List<string> _list = new List<string>();

    public void Push(string itemName)
    {
        _list.Add(itemName);
    }

    public string Pop()
    {
        var last = _list.Last();
        _list.Remove(last);
        return last;
    }

    public IIterator<String> CreateIterator()
    {
        return new ListIterator(this);
    }

    private class ListIterator : IIterator<String>
    {
        private ShoppingList _shoppingList;
        private int _index;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }

        public string Current()
        {
            return _shoppingList._list[_index];
        }

        public void Next()
        {
            _index++;
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count;
        }

    }
}