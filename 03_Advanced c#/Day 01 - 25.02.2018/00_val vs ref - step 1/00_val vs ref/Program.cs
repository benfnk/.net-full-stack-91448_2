namespace _00_val_vs_ref
{
    interface IEatable
    {
        bool IsEatable { get; set; }
    }

    delegate void delg();

    enum Color
    {
        magenta=2
    }

    class Pizza: IEatable
    {
        public bool IsEatable { get; set; }
        public bool IsVeg { get; set; }
    }

    struct Salad: IEatable
    {
        public bool IsEatable { get; set;}
        public bool IsVeg { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IEatable var1;
            delg var2;
            Color var3;
            Pizza var4;
            Salad var5;
        }
    }
}
