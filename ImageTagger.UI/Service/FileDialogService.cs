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
    //