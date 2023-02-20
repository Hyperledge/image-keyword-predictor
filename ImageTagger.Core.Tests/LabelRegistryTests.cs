namespace ImageTagger.Core.Tests;

public class LabelRegistryTests
{
    [Fact]
    public void Test_LabelRegistry_FileOk()
    {
        // Setup: Create a temporary labels file.
        var labels = new List<string>
        {
            "label1",
            "label2",
            "label3"
        };
        var labelsFile = Path.GetTempFileName();
        File.WriteAllLines(labelsFile, labels);

        // Test: Create a new LabelsRegistry instance.
        var labelsRegistry = new LabelsRegistry(labelsFile);

        // Verify: The labels are the same.
        Assert.Equal(3, labelsRegistry.Count);
       