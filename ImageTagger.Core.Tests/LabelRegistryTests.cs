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
        File.WriteAllLines(labelsFile,