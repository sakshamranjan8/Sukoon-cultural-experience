using UnityEngine;

public class UIFlowController : MonoBehaviour
{
    public GameObject mainMenuObjects;
    public GameObject characterSelectionPanel;

    public void OpenCharacterSelection()
    {
        if (mainMenuObjects != null)
        {
            mainMenuObjects.SetActive(false);
        }

        if (characterSelectionPanel != null)
        {
            characterSelectionPanel.SetActive(true);
        }
    }

    public void ReturnToMainMenu()
    {
        if (characterSelectionPanel != null)
        {
            characterSelectionPanel.SetActive(false);
        }

        if (mainMenuObjects != null)
        {
            mainMenuObjects.SetActive(true);
        }
    }
}