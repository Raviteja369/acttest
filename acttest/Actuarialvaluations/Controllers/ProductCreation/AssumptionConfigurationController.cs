
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
  public class AssumptionConfigurationController : Controller
  {
    public AssumptionConfigurationController(APIManager apiManager)
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
        List<AssumptionConfiguration> lstAssumptionConfiguration = new List<AssumptionConfiguration>();

        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "INITIAL_EXP_RAND" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "INITIAL_EXP_PC" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "REN_EXP_RAND" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "CLAIM_EXP_PC" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "REN_COMM_RAND" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "REN_COMM_PC1" });
        lstAssumptionConfiguration.Add(new AssumptionConfiguration { Variable = "REN_COMM_PC2" });

        var result = new EntityList<AssumptionConfiguration>
        {
          Total = lstAssumptionConfiguration.Count(),
          Entities = lstAssumptionConfiguration,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetAssumptionCode")]
    [HttpGet]
    public async Task<IActionResult> GetAssumptionCode()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "POLICY NUMBER" });
        lstDropDown.Add(new DropDown { Value = 2, Text = "INIT_POL" });
        lstDropDown.Add(new DropDown { Value = 3, Text = "AGE@ENTRY" });
        lstDropDown.Add(new DropDown { Value = 4, Text = "PH_ AGE_ENTRY" });
        lstDropDown.Add(new DropDown { Value = 5, Text = "GENDER" });
        lstDropDown.Add(new DropDown { Value = 6, Text = "AGE_ENTRY" });
        lstDropDown.Add(new DropDown { Value = 7, Text = "PREMIUM STATUS" });
        lstDropDown.Add(new DropDown { Value = 8, Text = "DURATION_IF_M" });
        lstDropDown.Add(new DropDown { Value = 9, Text = "UNDERWRITING_MODEL" });
        lstDropDown.Add(new DropDown { Value = 10, Text = "PREM__FREQ" });
        lstDropDown.Add(new DropDown { Value = 11, Text = "CLAIM_AMOUNT " });
        lstDropDown.Add(new DropDown { Value = 12, Text = "ANNUITY " });
        lstDropDown.Add(new DropDown { Value = 13, Text = "ANNUITY FREQUENCY " });
        lstDropDown.Add(new DropDown { Value = 14, Text = "ANNUITY_ADVANCE IND" });
        lstDropDown.Add(new DropDown { Value = 15, Text = "PLAN " });
        lstDropDown.Add(new DropDown { Value = 16, Text = "POL_TYPE" });
        lstDropDown.Add(new DropDown { Value = 17, Text = "TAX_CLASS" });
        lstDropDown.Add(new DropDown { Value = 18, Text = "NRA" });
        lstDropDown.Add(new DropDown { Value = 19, Text = "MARRIAGE STATUS" });
        lstDropDown.Add(new DropDown { Value = 20, Text = "INCOME " });
        lstDropDown.Add(new DropDown { Value = 21, Text = "SUM_ASSURED " });
        lstDropDown.Add(new DropDown { Value = 22, Text = "ORIG_LOAN" });
        lstDropDown.Add(new DropDown { Value = 23, Text = "OUSTANDING_LOAN" });
        lstDropDown.Add(new DropDown { Value = 24, Text = "ANNUAL PREMIUM" });
        lstDropDown.Add(new DropDown { Value = 25, Text = "RATE " });
        lstDropDown.Add(new DropDown { Value = 26, Text = "WAITING PERIOD" });
        lstDropDown.Add(new DropDown { Value = 27, Text = "OCCUPATION CLASS" });
        lstDropDown.Add(new DropDown { Value = 28, Text = "MEMBER_TYPE" });
        lstDropDown.Add(new DropDown { Value = 29, Text = "SA_ESC" });
        lstDropDown.Add(new DropDown { Value = 30, Text = "PREM_ESC" });
        lstDropDown.Add(new DropDown { Value = 31, Text = "PREM_ESC_MONTH" });
        lstDropDown.Add(new DropDown { Value = 32, Text = "SA_ESC_MONTH" });
        lstDropDown.Add(new DropDown { Value = 33, Text = "PREM_FREQ" });
        lstDropDown.Add(new DropDown { Value = 34, Text = "PAIDUP_OPTION" });
        lstDropDown.Add(new DropDown { Value = 35, Text = "PAIDUP_IND" });
        lstDropDown.Add(new DropDown { Value = 36, Text = "POL_TERM_M" });
        lstDropDown.Add(new DropDown { Value = 37, Text = "PREM_TERM_M" });
        lstDropDown.Add(new DropDown { Value = 38, Text = "TEMP_PW_IND" });
        lstDropDown.Add(new DropDown { Value = 39, Text = "TEMP_PW_MTH_EXIT" });
        lstDropDown.Add(new DropDown { Value = 40, Text = "FEE" });
        lstDropDown.Add(new DropDown { Value = 41, Text = "PREMIUM_WAIVER_OPTION" });
        lstDropDown.Add(new DropDown { Value = 42, Text = "PREM_WAVER_IND" });
        lstDropDown.Add(new DropDown { Value = 43, Text = "COMM_TYPE" });
        lstDropDown.Add(new DropDown { Value = 44, Text = "COMM_SCALE " });
        lstDropDown.Add(new DropDown { Value = 45, Text = "CASH BACK IND" });
        lstDropDown.Add(new DropDown { Value = 46, Text = "INCOME " });
        lstDropDown.Add(new DropDown { Value = 47, Text = "REPATRIATION" });
        lstDropDown.Add(new DropDown { Value = 48, Text = "OTHER1" });
        lstDropDown.Add(new DropDown { Value = 49, Text = "OTHER2" });
        lstDropDown.Add(new DropDown { Value = 50, Text = "EDUCATOR OPTION" });
        lstDropDown.Add(new DropDown { Value = 51, Text = "SEC" });
        lstDropDown.Add(new DropDown { Value = 52, Text = "INCOME " });
        lstDropDown.Add(new DropDown { Value = 53, Text = "EDUCATION " });
        lstDropDown.Add(new DropDown { Value = 54, Text = "OCCUPATION CLASS" });
        lstDropDown.Add(new DropDown { Value = 55, Text = "AGE" });

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
    [Route("GetAssumptionVariable")]
    [HttpGet]
    public async Task<IActionResult> GetAssumptionVariable()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "INITIAL_EXP_RAND" });
        lstDropDown.Add(new DropDown { Value = 2, Text = "INITIAL_EXP_PC" });
        lstDropDown.Add(new DropDown { Value = 3, Text = "REN_EXP_RAND" });
        lstDropDown.Add(new DropDown { Value = 4, Text = "REN_EXP_PC " });
        lstDropDown.Add(new DropDown { Value = 5, Text = "CLAIM_EXP_RAND" });
        lstDropDown.Add(new DropDown { Value = 6, Text = "CLAIM_EXP_PC" });
        lstDropDown.Add(new DropDown { Value = 7, Text = "INITIAL_COMM_RAND" });
        lstDropDown.Add(new DropDown { Value = 8, Text = "INITIAL_COMM_PC1" });
        lstDropDown.Add(new DropDown { Value = 9, Text = "INITIAL_COMM_PC2" });
        lstDropDown.Add(new DropDown { Value = 10, Text = "REN_COMM_RAND" });
        lstDropDown.Add(new DropDown { Value = 11, Text = "REN_COMM_PC1" });
        lstDropDown.Add(new DropDown { Value = 12, Text = "REN_COMM_PC2" });

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
