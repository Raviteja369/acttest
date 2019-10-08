
namespace Actuarialvaluations.Models.API
{
  /// <summary>
  /// The Transition Configuration
  /// </summary>
  public class TransitionConfiguration : Entity
  {
    /// <summary>
    /// Gets or sets TransitionID
    /// </summary>    
    public int TransitionID { get; set; }

    /// <summary>
    /// Gets or sets FromState
    /// </summary>
    public string FromState { get; set; }

    /// <summary>
    /// Gets or sets ToState
    /// </summary>
    public string ToState { get; set; }

    /// <summary>
    /// Gets or sets BaseTable
    /// </summary>
    public string BaseTable { get; set; }


    /// <summary>
    /// Gets or sets AdditionalTable1
    /// </summary>
    public string AdditionalTable1 { get; set; }

    /// <summary>
    /// Gets or sets AdditionalTable2
    /// </summary>
    public string AdditionalTable2 { get; set; }

    /// <summary>
    /// Gets or sets AdditionalTable3
    /// </summary>
    public string AdditionalTable3 { get; set; }

    /// <summary>
    /// Gets or sets Absorbing
    /// </summary>
    public bool Absorbing { get; set; }
  }
}
