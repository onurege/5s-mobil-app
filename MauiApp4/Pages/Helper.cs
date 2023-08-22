using DevExpress.Blazor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MauiApp4.Pages
{
    public class Helper
    {
        static QuestionList questionList = new();
        static List<Group> SectionGroups = new();

        public static List<Group> ConvertJsonFileToObjects(string sectionCode)
        {
            var assembly = typeof(Helper).GetTypeInfo().Assembly; // 'YourClassName' yerine bu kodun bulunduğu sınıfın adını yazın.
            Stream stream = assembly.GetManifestResourceStream("MauiApp4.Pages.data.json"); // 'YourNamespace' yerine projenizin adını (veya tam namespace yolunu) yazın.
       
            using (var reader = new StreamReader(stream))
            {
                var jsonContent = reader.ReadToEnd();

                try
                {
                    Root root = JsonConvert.DeserializeObject<Root>(jsonContent);
                    questionList = root.QuestionList[0];
                    SectionGroups = questionList.Sections.FirstOrDefault(s => s.QuestionListSectionCode == sectionCode).Groups;
                    return SectionGroups;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error reading the JSON file: " + ex.Message);
                }
            }

            return null;
        }
    }
}
