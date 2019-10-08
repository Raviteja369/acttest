namespace Actuarialvaluations.Controllers.ProductCreation
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;
  using Actuarialvaluations.API;
  using Actuarialvaluations.Models;
  using Actuarialvaluations.Models.API;
  using Microsoft.AspNetCore.Mvc;

  [Route("api/[controller]")]
  public class FileUploadController : Controller
  {
    public FileUploadController(APIManager apiManager)
    {
      this.APIManager = apiManager;
    }

    private APIManager APIManager { get; }

    // GET: api/<controller>
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery(Name = "skip")] int skip = 0, [FromQuery(Name = "take")] int take = 10, [FromQuery(Name = "sortBy")] string sortBy = "StateName", [FromQuery(Name = "sortDescending")] bool sortDescending = false)
    {
      try
      {
        List<FileUpload> lstFileUpload = new List<FileUpload>();

        lstFileUpload.Add(new FileUpload { Classification = "Assumption", TableName = "Lapse_Table", LocationType = "File System", Type = "Csv", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Model_Point ", TableName = "Mort_Base_Acc_Table", LocationType = "Cloud S3", Type = "Excel", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Transition Rates", TableName = "Mort_Base_Acc_Table", LocationType = "Cloud", Type = "xml", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Parameter", TableName = "Mort_Base_Table", LocationType = "File System", Type = "Csv", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Global ", TableName = "Mort_Impro_Table", LocationType = "Cloud S4", Type = "Excel", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Assumption", TableName = "AIDS_Table", LocationType = "Cloud", Type = "xml", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Model_Point ", TableName = "Disab_Temp_Table", LocationType = "File System", Type = "Csv", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Transition Rates", TableName = "Disab_Perm_Table", LocationType = "Cloud S5", Type = "Excel", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Parameter", TableName = "Retr_Table", LocationType = "Cloud", Type = "xml", Path = @"C:\XX\YY\ZZ" });
        lstFileUpload.Add(new FileUpload { Classification = "Global ", TableName = "Crit_Ill_Table", LocationType = "File System", Type = "Csv", Path = @"C:\XX\YY\ZZ" });

        var result = new EntityList<FileUpload>
        {
          Total = lstFileUpload.Count(),
          Entities = lstFileUpload,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetClassifications")]
    [HttpGet]
    public async Task<IActionResult> GetClassifications()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "Assumption" });
        lstDropDown.Add(new DropDown { Value = 2, Text = "Model_Point" });
        lstDropDown.Add(new DropDown { Value = 3, Text = "Transition Rates" });
        lstDropDown.Add(new DropDown { Value = 4, Text = "Parameter" });
        lstDropDown.Add(new DropDown { Value = 5, Text = "Global" });

        var result = new EntityList<DropDown>
        {
          Total = lstDropDown.Count(),
          Entities = lstDropDown,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetTableNames")]
    [HttpGet]
    public async Task<IActionResult> GetTableNames()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "Mort_Base_Acc_Table " });
        lstDropDown.Add(new DropDown { Value = 2, Text = "Mort_Base_Acc_Table " });
        lstDropDown.Add(new DropDown { Value = 3, Text = "Mort_Base_Table " });
        lstDropDown.Add(new DropDown { Value = 4, Text = "Mort_Impro_Table " });
        lstDropDown.Add(new DropDown { Value = 5, Text = "AIDS_Table " });
        lstDropDown.Add(new DropDown { Value = 6, Text = "Disab_Temp_Table " });
        lstDropDown.Add(new DropDown { Value = 7, Text = "Disab_Perm_Table " });
        lstDropDown.Add(new DropDown { Value = 8, Text = "Retr_Table " });
        lstDropDown.Add(new DropDown { Value = 9, Text = "Crit_Ill_Table " });
        lstDropDown.Add(new DropDown { Value = 10, Text = "Mat_Table " });
        lstDropDown.Add(new DropDown { Value = 11, Text = "Lapse_Table " });
        lstDropDown.Add(new DropDown { Value = 12, Text = "Full_Paid_UP_Table " });
        lstDropDown.Add(new DropDown { Value = 13, Text = "Semi_Paid_UP_Table " });
        lstDropDown.Add(new DropDown { Value = 14, Text = "Model Point " });
        lstDropDown.Add(new DropDown { Value = 15, Text = "Assumption Table  " });

        var result = new EntityList<DropDown>
        {
          Total = lstDropDown.Count(),
          Entities = lstDropDown,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetLocationTypes")]
    [HttpGet]
    public async Task<IActionResult> GetLocationTypes()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "File System " });
        lstDropDown.Add(new DropDown { Value = 2, Text = "Cloud S3 " });
        lstDropDown.Add(new DropDown { Value = 3, Text = "Cloud " });

        var result = new EntityList<DropDown>
        {
          Total = lstDropDown.Count(),
          Entities = lstDropDown,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetFileTypes")]
    [HttpGet]
    public async Task<IActionResult> GetFileTypes()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "Csv " });
        lstDropDown.Add(new DropDown { Value = 2, Text = "Excel " });
        lstDropDown.Add(new DropDown { Value = 3, Text = "xml " });


        var result = new EntityList<DropDown>
        {
          Total = lstDropDown.Count(),
          Entities = lstDropDown,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }
  }
}
