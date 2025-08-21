using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    internal class my
    {

        static void Main(string[] args)
        {
            string ns = "_24SOECE13043_Dharmraj_sodha.LAB2";

            for (int i = 1; i <= 15; i++)
            {
                string fileName = $"Q{i}.cs";
                string content = $@"using System;

namespace {ns}
{{
    class Q{i}
    {{
        static void Main(string[] args)
        {{
            
        }}
    }}
}}";

                File.WriteAllText(fileName, content);
                Console.WriteLine($"Created {fileName}");
            }
        }
    }
    }
