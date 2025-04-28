# Voice2Action

Custom voice2action, based on the original repo in the ALICE project

# How it works

Selection:

When a voice command is given, VoiceIntentController processes it and uses PropertyExtractor to understand the selection criteria

The selection state is tracked in m_SelectedControllers array in VoiceIntentController



### PropertyExtractor.cs

Extracts the shape type ("e.g. building") from voice command
fewShotPairs examples show how shape recognition is formatted

### ShapeController.cs

compares the requested shape with the object's shape

### Embeddings.cs
Maintains the shapeMap dictionary that maps shape names to their corresponding objects

### VoiceIntentController.cs
The main controller that orchestrates the entire voice command process
Calls the PropertyExtractor to extract properties from voice commands
Passes the extracted properties to the PropertyExecutor for execution

