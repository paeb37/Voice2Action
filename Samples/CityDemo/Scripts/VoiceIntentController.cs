using UnityEngine;
using UnityEngine.UI;

public class VoiceIntentController : MonoBehaviour
{
    public Text m_SelectionDisplay;
    private List<MyShapeController> m_SelectedControllers = new List<MyShapeController>();

    private void ResetSelection()
    {
        // Reset highlight for previously selected objects
        foreach (var controller in m_SelectedControllers)
        {
            if (controller is MyShapeController shapeController)
            {
                shapeController.SetSelectedHighlight(false);
            }
        }

        m_SelectedControllers.Clear();
        m_SelectionDisplay.text = "Selected: 0";
    }

    private void UpdateSelectionDisplay()
    {
        m_SelectionDisplay.text = $"Selected: {m_SelectedControllers.Count}";
        
        // Update highlights for all selected objects
        foreach (var controller in m_SelectedControllers)
        {
            if (controller is MyShapeController shapeController)
            {
                shapeController.SetSelectedHighlight(true);
            }
        }
    }
} 