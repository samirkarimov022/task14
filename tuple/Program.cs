namespace tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (int,int Num2, string Text) result = A();
            (int Num,int Num2, string Text ,string Text1) result1 = B();
            (int Num,int Num2, string Text ,bool) result2 = C();
            (int Num,int Num2, string Text,int Num3,string Text2) result3 = D();
            Console.WriteLine(result.Item1);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }
            static (int,int, string) A()
            {
                return (1,2, "alma");
            }
            static (int,int, string,string) B()
            {
                return (1,2, "alma","armud");
            }
            static (int,int, string,bool) C()
            {
                return (1,2, "alma",true);
            }
            static (int,int, string,int ,string) D()
            {
                return (1,2, "alma",5,"yemis");
            }

    }

}
