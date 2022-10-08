namespace ImageTagger.Core;

/// <summary>
///     LabelsRegistry holds the model labels.
/// </summary>
public class LabelsRegistry
{
    private readonly List<string> _labels;

    /// <summary>
    ///     Instantiates a new instance of LabelsRegistry.
    /// </summary>
    /// <param name="labelsFile">The labelsFile path.</param>
    public LabelsRegistry(string labelsFile)
    {
        _labels = new List<