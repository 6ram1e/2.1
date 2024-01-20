using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Укажите путь к вашему текстовому файлу
            string filePath = "test.txt";

            // Чтение трех предложений из файла
            string[] sentences = ReadSentences(filePath, 3);

            // Вывод предложений в обратном порядке
            Console.WriteLine("Предложения в обратном порядке:");
            for (int i = sentences.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sentences[i]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static string[] ReadSentences(string filePath, int count)
    {
        // Чтение текста из файла
        string text = File.ReadAllText(filePath);

        // Разделение текста на предложения
        string[] allSentences = text.Split('.', '!', '?');

        // Выбор первых count предложений
        string[] selectedSentences = new string[Math.Min(count, allSentences.Length)];
        Array.Copy(allSentences, selectedSentences, selectedSentences.Length);

        return selectedSentences;
    }
}
