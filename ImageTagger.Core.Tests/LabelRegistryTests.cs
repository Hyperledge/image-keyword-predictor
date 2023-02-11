namespace ImageTagger.Core.Tests;

public class LabelRegistryTests
{
    [Fact]
    public void Test_LabelRegistry_FileOk()
    {
        // Setup: Create a temporary labels file.
        var labels = new List<string>
        {
         