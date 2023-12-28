using System.Threading.Tasks;
using Avalonia.Controls;

namespace ImageTagger.UI.Service;

/// <summary>
///     FileDialogService is a service that provides a way to open a file dialog.
/// </summary>
public class FileDialogService : IFileDialogService
{
    private readonly bool _allowMultiple;
    private readonly string _dialogTitle;

    /// <summary>
    ///     Instantiates a new FileDialogService with the default dialog title.
    /// </summary>
    public FileDialogService() : this("Select Files")
    {
    }

    /// <summary>
    ///     Instantiates a new FileDialogService with the given dialog title.
    /// </summary>
    /// <param name="dialogTitl