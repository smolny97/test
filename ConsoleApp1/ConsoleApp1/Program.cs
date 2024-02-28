using System.Net.Sockets;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            transformer classtran = new transformer();          
            string test;
            Console.WriteLine("Введите размерность массива");
            classtran.mas1 = new int[Convert.ToInt32(Console.ReadLine())];
            classtran.mas2 = new string[classtran.mas1.Length];
            for (int i = 0; i < classtran.mas1.Length; i++)
            {
                Console.WriteLine("Введите элемент массива № " + i);
                classtran.mas1[i] = Convert.ToInt32(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("Введите номер задание для выполнения (1 2 3) или введите end для завершения работы");
                test = Console.ReadLine().ToString();
                if (test == "end")
                {
                    break;
                }
                if (test == "1")
                {
                    classtran.firsttask();
                }
                else if (test == "2")
                {
                    classtran.secondtask();
                }
                else if (test == "3")
                {
                    classtran.thirdtask();
                }
            }
            while (true);                      
        }
    }

    class transformer()
    {
        public int[] mas1 = new int[]{ };
        public string[] mas2 = new string[] { };
        public int x = 0;
        public void firsttask()
        {
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] % 3 != 0 && mas1[i] % 5 != 0)
                {
                    mas2[i] = mas1[i].ToString();
                    continue;
                }
                if (mas1[i] % 3 == 0 && mas1[i] % 5 == 0)
                {
                    mas2[i] = "fizz-buzz";
                    continue;
                }                    
                if (mas1[i] % 3 == 0)
                {
                    mas2[i] = "fizz";
                    continue;
                }
                mas2[i] = "buzz";                         
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
        }
        public void secondtask()
        {           
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] % 3 != 0 && mas1[i] % 4 != 0 && mas1[i] % 5 != 0 && mas1[i] % 7 != 0)
                {
                    mas2[i] = mas1[i].ToString();
                    continue;
                }
                if (mas1[i] % 3 == 0)
                {
                    mas2[i] = "fizz";

                }
                if (mas1[i] % 5 == 0 && mas2[i] != null)
                {
                    mas2[i] += "-buzz";
                }
                else if(mas1[i] % 5 == 0 && mas2[i] == null)
                {
                    mas2[i] = "buzz";
                }                              
                if (mas1[i] % 4 == 0 && mas2[i] != null)
                {
                    mas2[i] += "-muzz";
                }
                else if(mas1[i] % 4 == 0 && mas2[i] == null)
                {
                    mas2[i] = "muzz";
                }
                if (mas1[i] % 7 == 0 && mas2[i] != null)
                {
                    mas2[i] += "-guzz";
                }
                else if (mas1[i] % 7 == 0 && mas2[i] == null)
                {
                    mas2[i] = "guzz";
                }                
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }

        }
        public void thirdtask() //В притере тестового задания на число 12 должно выводить fizz-muzz в условии этого не было указано скорее всего это ошибка, поэтому я не стал ее добавлять
        {
            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] % 3 != 0 && mas1[i] % 4 != 0 && mas1[i] % 5 != 0 && mas1[i] % 7 != 0)
                {
                    mas2[i] = mas1[i].ToString();
                    continue;
                }
                if (mas1[i] % 3 == 0 && mas1[i] % 5 == 0)
                {
                    mas2[i] = "good-boy";
                }
                else if (mas1[i] % 3 == 0)
                {
                    mas2[i] = "dog";
                }
                else if (mas1[i] % 5 == 0)
                {
                    mas2[i] = "cat";
                }
                if (mas1[i] % 4 == 0 && mas2[i] != null)
                {
                    mas2[i] += "-muzz";
                }
                else if (mas1[i] % 4 == 0 && mas2[i] == null)
                {
                    mas2[i] = "muzz";
                }
                if (mas1[i] % 7 == 0 && mas2[i] != null)
                {
                    mas2[i] += "-guzz";
                }
                else if (mas1[i] % 7 == 0 && mas2[i] == null)
                {
                    mas2[i] = "guzz";
                }
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
        }
    }
}
