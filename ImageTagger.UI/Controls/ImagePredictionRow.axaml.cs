using System.IO;
using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Media.Imaging;
using Avalonia.Metadata;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Size = SixLabors.ImageSharp.Size;

namespace ImageTagger.UI.Controls;

/// <summary>
///     ImagePredictionRow is a custom control used to display an image and its predicted tags.
/// </summary>
public class ImagePredictionRow : TemplatedControl
{
    /// <summary>
    ///     Defines the PredictedImageTags property.
    /// </summary>
    public static readonly AvaloniaProperty<string> PredictedImageTagsProperty =
        AvaloniaProperty.Register<ImagePredictionRow, string>(nameof(PredictedImageTagsProperty));

    /// <summary>
    /