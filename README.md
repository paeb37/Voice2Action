# Voice2Action

Custom voice2action, based on the original repo in the ALICE project

# How it works

### VoiceIntentController.cs
- When a voice command is given, VoiceIntentController processes it and uses PropertyExtractor to understand what to select (the selection state is tracked in m_SelectedControllers)

### PropertyExtractor.cs
Extracts the shape type ("e.g. building") from voice command
The fewShotPairs examples show how shape recognition is formatted

### PropertyExecutor.cs
The property executor calls the appropriate method on the shape controller

### ShapeController.cs
Compares the requested shape with the object's shape

### Embeddings.cs
Maintains the shapeMap dictionary that maps shape names to their corresponding objects

