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
  public class TransitionConfigurationController : Controller
  {
    public TransitionConfigurationController(APIManager apiManager)
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
        List<TransitionConfiguration> lstTransitionConfiguration = new List<TransitionConfiguration>();
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 1,
          FromState = "Health",
          ToState = "Health",
          BaseTable = "N/A",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 9,
          FromState = "Health",
          ToState = "Health",
          BaseTable = "N/A",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 2,
          FromState = "Health",
          ToState = "Death",
          BaseTable = "Mort_Base_Acc_Table",
          AdditionalTable1 = "AIDS_Table",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = false
        });
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 3,
          FromState = "Health",
          ToState = "Lapse",
          BaseTable = "Lapse_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });

        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 4,
          FromState = "Health",
          ToState = "Temporary Disability",
          BaseTable = "Disab_Temp_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });


        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 5,
          FromState = "Health",
          ToState = "Permanent Disability",
          BaseTable = "Disab_Perm_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = false
        });


        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 6,
          FromState = "Health",
          ToState = "Retrenchment",
          BaseTable = "Retr_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 7,
          FromState = "Health",
          ToState = "Critial Illness",
          BaseTable = "Crit_Ill_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = true
        });
        lstTransitionConfiguration.Add(new TransitionConfiguration
        {
          TransitionID = 8,
          FromState = "Health",
          ToState = " Paid - Up",
          BaseTable = "Semi_Paid_UP_Table",
          AdditionalTable1 = "N/A",
          AdditionalTable2 = "N/A",
          AdditionalTable3 = "N/A",
          Absorbing = false
        });
        var result = new EntityList<TransitionConfiguration>
        {
          Total = lstTransitionConfiguration.Count(),
          Entities = lstTransitionConfiguration,
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
