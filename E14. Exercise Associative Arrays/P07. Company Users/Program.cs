namespace CompanyUsers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyId = new Dictionary<string, List<string>>();
            string command = string.Empty;
            command = PrintAllCompaniesId(companyId);
        }

        private static string PrintAllCompaniesId(Dictionary<string, List<string>> companyId)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arrayCommand = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string nameCompany = arrayCommand[0];
                string id = arrayCommand[1];
                if (!companyId.ContainsKey(nameCompany))
                {
                    companyId.Add(nameCompany, new List<string>());
                }
                if (companyId[nameCompany].Any(x => x.Contains(id)))
                {
                    continue;
                }
                companyId[nameCompany].Add(id);
            }
            foreach (var currentId in companyId)
            {
                Console.WriteLine(currentId.Key);
                /* друг начин за принтиране 
                 foreach (var employeeId in currentId.Value)
                 {
                     Console.WriteLine($"-- {employeeId}");
                 }*/
                currentId.Value.ForEach(x => Console.WriteLine($"-- {x}"));
            }
            Console.Read();
            return command;
        }
    }
}
