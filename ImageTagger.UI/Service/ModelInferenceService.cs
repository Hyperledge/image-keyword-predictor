using System.IO;
using System.Linq;
using System.Reflection;
using ImageTagger.Core;

namespace ImageTagger.UI.Service;

/// <summary>
///     ModelInference class is used to predict tags for given images.
/// </summary>
public class ModelInferenceService : IModelInferenceSe