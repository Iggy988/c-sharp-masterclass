
//custom attribute
class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type.GetProperties()
            // select those properties of this type for which is this attribute defined
            .Where(prop => Attribute.IsDefined(prop, typeof(StringLengthValidate)));

        foreach (var prop in propertiesToValidate)
        {
            object? propertyValue = prop.GetValue(obj);
            // prvo provjeravamo da li je properyValue string
            if (propertyValue is not string)
            {
                throw new InvalidOperationException($"Attribute {nameof(StringLengthValidate)} can only be applied to strings");
            }

            // validate
            var value = (string)propertyValue; // cast property to string, it is safe, we checked lines before
            var attribute = (StringLengthValidate)prop.GetCustomAttributes(typeof(StringLengthValidate), true).First();
            if (value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {prop.Name} is ivalid, value is {value}");
                return false;
            }
        }

        return true;
        
    }
}
