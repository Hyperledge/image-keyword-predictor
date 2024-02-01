namespace ImageTagger.UI.Service;

public interface IModelInferenceService
{
    /// <summary>
    ///     Returns the predicted tags for the given image.
    /// </summary>
    /// <param name="imagePath">The absolute path to the image for predicting the tags.</param>
    /