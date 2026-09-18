using UnityEngine;

public class CharacterSelectionController : MonoBehaviour
{
    private string selectedCharacter = "Boy";

    public void SelectBoy()
    {
        selectedCharacter = "Boy";
        Debug.Log("Selected character: Boy");
    }

    public void SelectGirl()
    {
        selectedCharacter = "Girl";
        Debug.Log("Selected character: Girl");
    }

    public string GetSelectedCharacter()
    {
        return selectedCharacter;
    }
}