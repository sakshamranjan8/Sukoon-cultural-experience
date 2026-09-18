using UnityEngine;

public class UIFlowController : MonoBehaviour
{
    public GameObject mainMenuObjects;
    public GameObject destinyBookPanel;

    public void OpenDestinyBook()
    {
        if (mainMenuObjects != null)
        {
            mainMenuObjects.SetActive(false);
        }

        if (destinyBookPanel != null)
        {
            destinyBookPanel.SetActive(true);
        }
    }
}