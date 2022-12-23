using System.Reflection;

namespace ImageTagger.Core.Tests;

public class ImageProcessorTests
{
    private readonly ImageProcessor _imageProcessor;
    private readonly string _testImagePath;

    public ImageProcessorTests()
    {
        var assemblyBasePath = Assembly.GetExec