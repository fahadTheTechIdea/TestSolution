using Beep.DeveloperAssistant.Logic.Models;
using System.Collections.Generic;
using System.IO;


namespace Beep.DeveloperAssistant.Logic
{
    public class DeveloperAssistantManager
    {
        public DeveloperAssistantManager()
        {
            
        }
      //  private IDMEEditor DMEEditor;
        //public DeveloperAssistantManager(IDMEEditor pDMEEditor)
        //{
        //    DMEEditor = pDMEEditor;
        //}
        public List<CodeTemplates> Templates { get; set; }  =new List<CodeTemplates>();
        //public void SaveTemplates()
        //{
        //    string filename = Path.Combine(DMEEditor.ConfigEditor.Config.ScriptsPath, "DeveloperAssistantScripts.json");
        //    DMEEditor.ConfigEditor.JsonLoader.Serialize(filename,Templates);
        //}
        //public void LoadTemplates() {
        //    string filename = Path.Combine(DMEEditor.ConfigEditor.Config.ScriptsPath, "DeveloperAssistantScripts.json");
        //    Templates=DMEEditor.ConfigEditor.JsonLoader.DeserializeObject<CodeTemplates>(filename);
        //}
    }
}
