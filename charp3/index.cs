using System;
using System.Collections.Generic;

namespace DisciplineEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> bachelorDisciplines = new Dictionary<int, string>()
            {
                { 1, "Основи програмування" },
                { 2, "Організація комп'ютерних мереж" },
                { 3, "Вища математика" },
                { 4, "Дискретна математика" }
            };

            Dictionary<int, string> masterDisciplines = new Dictionary<int, string>()
            {
                { 1, "Архітектура комп'ютера" },
                { 2, "Іноземна мова" },
                { 3, "Економіка" },
                { 4, "Менеджмент" }
            };

            Console.WriteLine("Програма переліку дисциплін професійної підготовки");
            Console.WriteLine("Автор: Охріменко\n");

            Console.WriteLine("Дисципліни для бакалаврів:");
            PrintDisciplines(bachelorDisciplines);

            Console.WriteLine("Дисципліни для магістрів:");
            PrintDisciplines(masterDisciplines);

            Console.WriteLine("Введіть номери дисциплін, які бажаєте вивчати :");
            string input = Console.ReadLine();
            List<int> selectedDisciplines = GetSelectedDisciplines(input);

            Console.WriteLine("Ви обрали наступні дисципліни:");
            PrintSelectedDisciplines(selectedDisciplines, bachelorDisciplines, "Дисципліни для бакалаврів:");
            PrintSelectedDisciplines(selectedDisciplines, masterDisciplines, "Дисципліни для магістрів:");
        }

        static void PrintDisciplines(Dictionary<int, string> disciplines)
        {
            foreach (var discipline in disciplines)
            {
                Console.WriteLine($"{discipline.Key} - {discipline.Value}");
            }
        }

        static List<int> GetSelectedDisciplines(string input)
        {
            string[] inputArray = input.Split(',');
            List<int> selectedDisciplines = new List<int>();

            foreach (var item in inputArray)
            {
                if (int.TryParse(item, out int disciplineNumber))
                {
                    selectedDisciplines.Add(disciplineNumber);
                }
            }

            return selectedDisciplines;
        }

        static void PrintSelectedDisciplines(List<int> selectedDisciplines, Dictionary<int, string> disciplines, string header)
        {
            Console.WriteLine(header);
            foreach (var discipline in disciplines)
            {
                if (selectedDisciplines.Contains(discipline.Key))
                {
                    Console.WriteLine($"{discipline.Key} - {discipline.Value}");
                }
            }
        }
    }
}