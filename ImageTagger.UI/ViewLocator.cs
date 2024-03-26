using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using ImageTagger.UI.ViewModels;

namespace ImageTagger.UI;

public class ViewLocator : IDataTemplate
{
    public Control Build(object? data)
    {
        var name = data!.GetType().FullName!