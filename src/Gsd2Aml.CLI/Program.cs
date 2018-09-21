using System.Collections.Generic;

namespace Gsd2Aml.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parameter = new Dictionary<string, string>
            {
                { "-path", null },
                { "-file", null }
            };

            for (int i = 0; i < args.Length; i++)
            {
                if (parameter.ContainsKey(args[i]))
                {
                    parameter[args[i]] = args[++i];
                }
            }
        }
    }
}
