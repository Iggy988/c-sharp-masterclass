
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write

//Data structures are types meant for storing and orginizing data so that it can be accessed and modified efficiently
// arrays, stacks, queues, dictionaries..,

//var numbers = new List<int> { 1, 2, 3, 4, 5 };
//var words = new List<string> { "ime", "prezime", "godina"};
//var dates = new List<DateTime> { new DateTime(day: 12, month: 3, year: 2023)};







class ListOfStrings
{
    private string[] _items = new string[4];
    private int _size = 0;

    public void Add(string item)
    {
        //check is array size is larger or equal arrays length
        if (_size >= _items.Length)
        {
            //if so, we create new array, snd double the size of old one
            var newItems = new string[_items.Length * 2];
            //iterating old array and copy its elements one by one to new array
            for (int i = 0; i < _items.Length; ++i)
            {
                newItems[i] = _items[i];
            }
            //replace old with new array
            _items = newItems;
        }

        _items[_size] = item;
        ++_size;
    }

    //remove item by given index
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
        }
        --_size;

        for (int i = index; i < _size; ++i)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = null;
    }

    public string GetAtIndex(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
        }
        return _items[index];
    }
}
