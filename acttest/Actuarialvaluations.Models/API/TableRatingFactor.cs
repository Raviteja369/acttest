
namespace Actuarialvaluations.Models.API
{
  /// <summary>
  /// The Table Rating Factors
  /// </summary>
  public class TableRatingFactor : Entity
  {
    /// <summary>
    /// Gets or sets TableRatingFactorsID
    /// </summary>    
    public int TableRatingFactorsID { get; set; }

    /// <summary>
    /// Gets or sets Table Name
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// Gets or sets Rating Factor 1
    /// </summary>
    public string RatingFactor1 { get; set; }

    /// <summary>
    /// Gets or sets Dimension 1
    /// </summary>
    public string Dimension1 { get; set; }

    /// <summary>
    /// Gets or sets Rating Factor 2
    /// </summary>
    public string RatingFactor2 { get; set; }

    /// <summary>
    /// Gets or sets Dimension 2
    /// </summary>
    public string Dimension2 { get; set; }

    /// <summary>
    /// Gets or sets Rating Factor 3
    /// </summary>
    public string RatingFactor3 { get; set; }

    /// <summary>
    /// Gets or sets Dimension 3
    /// </summary>
    public string Dimension3 { get; set; }

    /// <summary>
    /// Gets or sets Rating Factor 4
    /// </summary>
    public string RatingFactor4 { get; set; }

    /// <summary>
    /// Gets or sets Dimension 4
    /// </summary>
    public string Dimension4 { get; set; }
  }
}
