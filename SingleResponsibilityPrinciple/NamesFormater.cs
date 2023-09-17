

class NamesFormater
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine + "-----" + Environment.NewLine, names);
    }
}

