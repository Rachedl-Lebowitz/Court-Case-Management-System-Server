using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models.DTO
{
    public class UploadDocumentDto
    {
        public string Title { get; set; }
        public byte[] Content { get; set; }
    }
}
