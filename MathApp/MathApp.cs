using System;

namespace Math 
{
    class Program 
    {
        static void Main(string[] args)
        {
            var numbers = new List<float> {4.0f, 9.0f, 16.0f, 25.0f, 36.0f};
            float[] results = new float[numbers.Count * 2];
            for (int i = 0; i < numbers.Count; i++)
            {
                float number = numbers[i];

                results[i * 2] = MathF.Sqrt(number);
                results[i * 2 + 1] = MathF.Sin(number);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Number: {numbers[i]}, Sqrt: {results[i * 2]}, Sin: {results[i * 2 + 1]}");
            }
        }
    }
}
