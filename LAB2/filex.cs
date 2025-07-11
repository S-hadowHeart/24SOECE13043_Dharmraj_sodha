using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    internal class filex
    {
        public static void Main(string[] args)
        {
            // Get current directory where the program is executed
            string currentDir = Directory.GetCurrentDirectory();

            for (int i = 1; i <= 10; i++)
            {
                string fileName = $"Q{i}.cs";
                string filePath = Path.Combine(currentDir, fileName);

                // Optional: Add a simple template content
                string fileContent = $"// This is {fileName}\nusing System;\n\nclass Q{i}\n{{\n    static void Main()\n    {{\n        Console.WriteLine(\"Hello from {fileName}!\");\n    }}\n}}";

                // Create the file
                File.WriteAllText(filePath, fileContent);
                Console.WriteLine($"Created: {fileName}");
            }

            Console.WriteLine("All files created successfully.");
        }
    }
}
