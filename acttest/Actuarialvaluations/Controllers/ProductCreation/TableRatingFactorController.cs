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
  public class TableRatingFactorController : Controller
  {
    public TableRatingFactorController(APIManager apiManager)
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
        List<TableRatingFactor> lstTableRatingFactor = new List<TableRatingFactor>();
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 1,
          TableName = "Table 1",
          RatingFactor1 = "Age",
          Dimension1 = "0.5",
          RatingFactor2 = "AGE_ENTRY",
          Dimension2 = "0.89",
          RatingFactor3 = "PH_ AGE_ENTRY",
          Dimension3 = "0.98",
          RatingFactor4 = "GENDER",
          Dimension4 = "1.25",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 2,
          TableName = "Table 2",
          RatingFactor1 = "Age",
          Dimension1 = "0.5",
          RatingFactor2 = "AGE_ENTRY",
          Dimension2 = "0.89",
          RatingFactor3 = "PH_ AGE_ENTRY",
          Dimension3 = "0.98",
          RatingFactor4 = "GENDER",
          Dimension4 = "1.25",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 3,
          TableName = "Table 3",
          RatingFactor1 = "AGE_ENTRY",
          Dimension1 = "2.02",
          RatingFactor2 = "PREMIUM_STATUS",
          Dimension2 = "3.35",
          RatingFactor3 = "DURATION_IF_M",
          Dimension3 = "5.24",
          RatingFactor4 = "UNDERWRITING_MODEL",
          Dimension4 = "2.658",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 4,
          TableName = "Table 4",
          RatingFactor1 = "PREM__FREQ",
          Dimension1 = "0.24",
          RatingFactor2 = "ANNUITY_FREQ",
          Dimension2 = "0.325",
          RatingFactor3 = "PLAN",
          Dimension3 = "3.21",
          RatingFactor4 = "POL_TYPE",
          Dimension4 = "8.02",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 5,
          TableName = "Table 5",
          RatingFactor1 = "TAX_CLASS",
          Dimension1 = "2",
          RatingFactor2 = "MEMBER_TYPE",
          Dimension2 = "7",
          RatingFactor3 = "PREM_FREQ",
          Dimension3 = "8",
          RatingFactor4 = "COMM_TYPE",
          Dimension4 = "9",
        });

        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 6,
          TableName = "Table 6",
          RatingFactor1 = "INCOME",
          Dimension1 = "1.20",
          RatingFactor2 = "SEC",
          Dimension2 = "3.20",
          RatingFactor3 = "INCOME",
          Dimension3 = "3.20",
          RatingFactor4 = "EDUCATION",
          Dimension4 = "10.23",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 7,
          TableName = "Table 7",
          RatingFactor1 = "OCC_CLASS",
          Dimension1 = "4.0021",
          RatingFactor2 = "PREMIUM_STATUS",
          Dimension2 = "3.02",
          RatingFactor3 = "ANNUITY_FREQ",
          Dimension3 = "20.3",
          RatingFactor4 = "COMM_TYPE",
          Dimension4 = "0.021",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 8,
          TableName = "Table 8",
          RatingFactor1 = "Age",
          Dimension1 = "0.5",
          RatingFactor2 = "AGE_ENTRY",
          Dimension2 = "0.89",
          RatingFactor3 = "PH_ AGE_ENTRY",
          Dimension3 = "0.98",
          RatingFactor4 = "GENDER",
          Dimension4 = "1.25",
        });
        lstTableRatingFactor.Add(new TableRatingFactor
        {
          TableRatingFactorsID = 9,
          TableName = "Table 9",
          RatingFactor1 = "AGE_ENTRY",
          Dimension1 = "2.02",
          RatingFactor2 = "PREMIUM_STATUS",
          Dimension2 = "3.35",
          RatingFactor3 = "DURATION_IF_M",
          Dimension3 = "5.24",
          RatingFactor4 = "UNDERWRITING_MODEL",
          Dimension4 = "2.658",
        });

        var result = new EntityList<TableRatingFactor>
        {
          Total = lstTableRatingFactor.Count(),
          Entities = lstTableRatingFactor,
        };
        return this.Ok(result);
      }
      catch (Exception ex)
      {
        return this.BadRequest(ex.Message);
      }
    }

    // GET: api/<controller>
    [Route("GetRefactors")]
    [HttpGet]
    public async Task<IActionResult> GetRefactors()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = -1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 1,
          Text = "AGE"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 2,
          Text = "AGE_ENTRY"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 3,
          Text = "PH_ AGE_ENTRY"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 4,
          Text = "GENDER"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 5,
          Text = "AGE_ENTRY"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 6,
          Text = "PREMIUM_STATUS"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 7,
          Text = "DURATION_IF_M"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 8,
          Text = "UNDERWRITING_MODEL"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "PREM__FREQ"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "ANNUITY_FREQ"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "PLAN"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "POL_TYPE"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "TAX_CLASS"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "MEMBER_TYPE"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "PREM_FREQ"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "COMM_TYPE"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "INCOME"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "SEC"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "INCOME"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "EDUCATION"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "OCC_CLASS"
        });
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
    [Route("GetTableName")]
    [HttpGet]
    public async Task<IActionResult> GetTableName()
    {
      try
      {
        List<DropDown> lstDropDown = new List<DropDown>();
        lstDropDown.Add(new DropDown
        {
          Value = 1,
          Text = "N/A"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 2,
          Text = "Mort_Base_Acc_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 3,
          Text = "Mort_Base_Acc_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 4,
          Text = "Mort_Base_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 5,
          Text = "Mort_Impro_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 6,
          Text = "AIDS_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 7,
          Text = "Disab_Temp_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 8,
          Text = "Disab_Perm_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Retr_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Crit_Ill_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Mat_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Lapse_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Full_Paid_UP_Table"
        });
        lstDropDown.Add(new DropDown
        {
          Value = 9,
          Text = "Semi_Paid_UP_Table"
        });
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
