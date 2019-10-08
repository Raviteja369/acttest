namespace Actuarialvaluations.Models.API
{
  /// <summary>
  /// Gets or sets Applicable Model Point Variable
  /// </summary>
  public class FileUpload
  {
    /// <summary>
    /// Gets or sets File Classification
    /// </summary>
    public string Classification { get; set; }

    /// <summary>
    /// Gets or sets Table Name
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// Gets or sets Location Type
    /// </summary>
    public string LocationType { get; set; }

    /// <summary>
    /// Gets or sets File Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets File Path
    /// </summary>
    public string Path { get; set; }
  }
}
