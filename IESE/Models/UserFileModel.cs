using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Models
{
    public class UserFileModel
    {
        public IFormFile File { get; set; }
    }
}
