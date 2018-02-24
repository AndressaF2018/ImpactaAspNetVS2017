using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capitulo02.Repeticao.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void ForAninhadoTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine($" {i} * {j} = {i *j}");
                }
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
