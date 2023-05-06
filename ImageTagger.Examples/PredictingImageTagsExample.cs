﻿using ImageTagger.Core;

/*
 * Example use of ImageTagger core library.
 */


// Specify the paths to the model and labels files.
const string modelPath = @"RiderProjects\ImageTagger\ImageTagger.Core\AIModels\prediction.onnx";
const string labelsPath = @"RiderProjects\ImageTagger\ImageTagger.Core\AIModels\prediction_categories.txt";

// Create a new instance of ModelPrediction.
var modelPrediction = new Mo