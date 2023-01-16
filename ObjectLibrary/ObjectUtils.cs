namespace ObjectLibrary;
public class ObjectUtils
{

    public static bool isStringEmpty(string str)
    {
        if (str is null)
        {
            return true;
        }
        if (str.Equals(""))
        {
            return true;
        }
        if (str.Trim().Equals(""))
        {
            return true;
        }
        return false;
    }

    public static bool isEnumerableEmpty(IEnumerable<Object> e)
    {
        if (e is null)
        {
            return true;
        }
        if (e.Count().Equals(0))
        {
            return true;
        }

        return false;
    }

}

