
using System;

namespace ImageTagger.UI.Views.MainWindow;

/**
 * PredictionStats is a simple class to keep track of prediction statistics.
 */
internal record PredictionStats
{
    /**
     * FilesPredicted tracks the files predicted count.
     */
    public int FilesPredicted { get; set; }

    /**
     * TimeElapsed tracks the prediction's elapsed time.
     */
    public TimeSpan TimeElapsed { get; set; }
}