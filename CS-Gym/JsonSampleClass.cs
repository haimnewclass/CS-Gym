using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    
    public class JsonSampleClass
    {
        public string id { get; set; }
        public string title { get; set; }
        public string schemaVersion { get; set; }
        public string testVersion { get; set; }
        public string previousVersionId { get; set; }
        public string authorId { get; set; }
        public string description { get; set; }
        public string[] tags { get; set; }
        public string[] questionsRefs { get; set; }
    }

}
