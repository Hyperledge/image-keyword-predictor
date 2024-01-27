
using System.Threading.Tasks;
using Avalonia.Controls;

namespace ImageTagger.UI.Service;

public interface IFileDialogService
{
    /// <summary>
    ///     Opens a file dialog with the given parent window.
    /// </summary>
    /// <param name="parentWindow">The window.</param>
    /// <returns>Returns an array of file names.</returns>
    Task<string[]?> OpenDialog(Window parentWindow);
}