using System;
using System.Collections.Generic;
using System.Text;

namespace Beep.DeveloperAssistant.Logic.Models
{
    public class CodeTemplates
    {
        public CodeTemplates() { }
       
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string GuidID { get;set; }

        public string Header { get; set; }
        public string Footer { get;set; }
        public string Content { get; set; }


    }
}
