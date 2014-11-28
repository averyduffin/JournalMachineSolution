using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalMachine.ObjectModel
{
    class facebook : SocialMediaInterface
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public string PictureUrl { get; set; }
        public string ExternalLink { get; set; }
    }
}
