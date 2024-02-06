namespace ImageTagger.UI.Service;

public interface IModelInferenceService
{
    /// <summary>
    ///     Returns the predicted tags for the given image.
    /// </summary>
    /// <param name="imagePath">The absolute path to the image for predicting the tags.</param>
    /// <param name="separator">The separator for the predicted tags</param>
    /// <returns>The