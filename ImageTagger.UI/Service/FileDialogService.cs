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
    /// <param name="dialogTitle">The given dialog title.</param>
    /// <param name="allowMultiple">If true allows selection of multiple files.</param>
    public FileDialogService(string dialogTitle, bool allowMultiple = true)
    {
        _dialogTitle = dialogTitle;
        _allowMultiple = allowMultiple;
    }

    /// <summary>
    