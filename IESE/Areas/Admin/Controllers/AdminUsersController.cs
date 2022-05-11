using ClosedXML.Excel;
using IESE.Domain;
using IESE.Domain.Entities;
using IESE.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESE.Areas.Admin.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminUsersController : ControllerBase
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;

        public AdminUsersController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
        }


        [HttpPost]
        public async Task<IActionResult> PostFile([FromForm] UserFileModel model)
        {
            using (XLWorkbook workBook = new XLWorkbook(model.File.OpenReadStream(), XLEventTracking.Disabled))
            {
                foreach (IXLWorksheet worksheet in workBook.Worksheets)
                {
                    foreach (IXLRow row in worksheet.RowsUsed().Skip(1))
                    {
                        try
                        {
                            ApplicationUser user = new ApplicationUser();
                            user.Surname = row.Cell(1).Value.ToString();

                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }
                }
            }
                return NotFound();
        }
    }
}
