namespace MVC2
{
    public static class Constants
    {
        public static Inner Inner = new Inner();   
    }

    public class Inner
    {
        public string Value = "Hello";
    }
}

namespace ThreeHundredRepro
{
    public static class MVC
    {
        public static Constants2 Constants2 => new Constants2();
    }

    public class Constants2
    {
        public Inner Inner = new Inner();
    }

    public class Inner
    {
        public string _value = "Hello";
    }
}
