using System;
using System.Threading.Tasks;

/*
 * Необходимо реализовать многопоточный генератор шаблонного
 * кода тестовых классов для одной из библиотек для тестирования (NUnit, xUnit, MSTest) по тестируемым классам.
Входные данные: 
список файлов, для классов из которых необходимо сгенерировать тестовые классы;
путь к папке для записи созданных файлов;
ограничения на секции конвейера  (см. далее).
 */

namespace TestProject
{
    class Program
    {
        public static async Task Main()
        {
            await new Pipeline().Generate(2,
                @"/Users/nikita/Desktop/SPP_4/GeneratedTests",
                @"/Users/nikita/Desktop/SPP_4/TestProject/TestClass.cs",
                @"/Users/nikita/Desktop/SPP_4/TestProject/AnotherTestClass.cs"); 
        }
    }
}