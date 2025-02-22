using LibraryB;
using LibraryC;
using LibraryD;

namespace LibraryA
{
    public class ClassA
    {
        public void HelloA()
        {
            Console.WriteLine("Hello from class A");
            ClassB.HelloB();
            ClassC.HelloC();
            ClassD.HelloD();
        }
    }
}
