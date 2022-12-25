using System.Reflection;

namespace ImageTagger.Core.Tests;

public class ImageProcessorTests
{
    private readonly ImageProcessor _imageProcessor;
    private readonly string _testImagePath;

    public ImageProcessorTests()
    {
        var assemblyBasePath = Assembly.GetExecutingAssembly().Location;
        var assemblyPath = Path.GetDirectoryName(assemblyBasePath);
        _testImagePath = Path.Join(assemblyPath, "resources", "test-image.jpg");
        _imageProcessor = new ImageProcessor();
    }

    [Fact]
    public void Test_Pro