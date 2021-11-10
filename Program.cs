using System.Collections.Generic;

namespace ConsoleLabsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGlobal> obj = new List<IGlobal>();

            obj.Add(new Tovar());
            obj.Add(new Auto());
            obj.Add(new Rent());

            foreach (IGlobal item in obj)
                item.Input();

            foreach (IGlobal item in obj)
                item.Output();

            return;
        }
    }
}
