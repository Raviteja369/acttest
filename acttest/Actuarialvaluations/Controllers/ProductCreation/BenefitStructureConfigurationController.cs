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
  public class BenefitStructureConfigurationController : Controller
  {
    public BenefitStructureConfigurationController(APIManager apiManager)
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
        List<BenefitStructureConfiguration> lstBenefitStructureConfiguration = new List<BenefitStructureConfiguration>();

        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "CASHBACK" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "PAIDUP" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "BENEFIT_ESCALATION" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "PREMIUM_ESCALATION" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "ACCIDENTAL_BE" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "SURRENDER_BEN" });
        lstBenefitStructureConfiguration.Add(new BenefitStructureConfiguration { Variable = "UNIT_FUN" });

        var result = new EntityList<BenefitStructureConfiguration>
        {
          Total = lstBenefitStructureConfiguration.Count(),
          Entities = lstBenefitStructureConfiguration,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetBenefitFeature")]
    [HttpGet]
    public async Task<IActionResult> GetBenefitFeature()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown { Value = 1, Text = "JOINT_LIFE" });
        lstDropDown.Add(new DropDown { Value = 2, Text = "ANNUITY_INCOME" });
        lstDropDown.Add(new DropDown { Value = 3, Text = "CASHBACK" });
        lstDropDown.Add(new DropDown { Value = 4, Text = "ACCIDENTAL_BEN" });
        lstDropDown.Add(new DropDown { Value = 5, Text = "FULL_PAIDUP" });
        lstDropDown.Add(new DropDown { Value = 6, Text = "REDUCED_PAIDUP" });
        lstDropDown.Add(new DropDown { Value = 7, Text = "PREMIUM WAIVER ON DEATH" });
        lstDropDown.Add(new DropDown { Value = 8, Text = "PREMIUM WAIVER ON DISABILITY" });
        lstDropDown.Add(new DropDown { Value = 9, Text = "PREMIUM ESCALATION" });
        lstDropDown.Add(new DropDown { Value = 10, Text = "BENEFIT ESCALATION" });
        lstDropDown.Add(new DropDown { Value = 11, Text = "SURRENDER_BEN" });
        lstDropDown.Add(new DropDown { Value = 12, Text = "UNIT_FUN" });
        lstDropDown.Add(new DropDown { Value = 13, Text = "WITH_PROFIT" });
        lstDropDown.Add(new DropDown { Value = 14, Text = "STERLING" });

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
