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
        _labels = new List<string>();
        // Read the labels file and add the labels to the list.
        using var sr = new StreamReader(labelsFile);
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine(