namespace Actuarialvaluations.Models.API
{
  /// <summary>
  /// The Markov state class
  /// </summary>
  public class DropDown : Entity
  {
    /// <summary>
    /// Gets or sets ID
    /// </summary>    
    public int Value { get; set; }

    /// <summary>
    /// Gets or sets Value
    /// </summary>
    public string Text { get; set; }
  }
}
