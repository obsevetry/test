using System;

namespace _20190830_3
{
    class Program
    {

        // Определить закрыты ли все скобки во веденной строке. Виды скобок (),{},[]

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки:");
            string strInput = Console.ReadLine();

            const string openSkobs = "({[";
            const string closedSkobs = ")}]";

            string strResult = "Все скобки закрыты";
            bool isError = false;

            // если длина строки нечетная, тогда нет смысла проверять дальше
            if ((strInput.Length % 2) == 0)
            {
                // Обход и проверка конкретного вида скобки
                for (int j = 0; j < openSkobs.Length; j++)
                {
                    string currentOpenScob = openSkobs[j].ToString();
                    string currentclosedScob = closedSkobs[j].ToString();

                    // Количество скобок также должно быть одинаково
                    if (strInput.Split(currentOpenScob).Length == strInput.Split(currentclosedScob).Length)
                    {

                        // на каждую открытую ищем закрытую скобку,
                        // и первая скобка обязательно должна быть открытой
                        bool firstFindScobIsGood = false;
                        for (int i = 0; i < strInput.Length; i++)
                        {
                            // Обрабатываем только скобки одного вида
                            if (strInput[i].ToString() != currentOpenScob && strInput[i].ToString() != currentclosedScob)
                            {
                                continue;
                            }
                            if (currentOpenScob == strInput[i].ToString())
                            {
                                firstFindScobIsGood = true;
                            }
                            if (!firstFindScobIsGood && currentclosedScob == strInput[i].ToString())
                            {
                                isError = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        isError = true;
                    }

                    if (isError)
                    {
                        break;
                    }

                }
            }
            else
            {
                isError = true;
            }

            if (isError)
            {
                strResult = "НЕ все скобки закрыты";
            }

            Console.WriteLine("_____________________");
            Console.WriteLine(strResult);
            Console.ReadKey();

        }
    }
}
