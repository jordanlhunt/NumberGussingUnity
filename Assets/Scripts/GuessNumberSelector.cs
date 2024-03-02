using UnityEngine;

// Attach to GussesNumberSelector EGO in SceneStart
public class GuessNumberSelector : MonoBehaviour
{
    public TMPro.TMP_Dropdown guessesSelectorDropdown;

    // Called by SceneStart.DropdownGuesses
    public void SetMaximumGuesses()
    {
        if (guessesSelectorDropdown.value == 0)
        {
            NumberGuessUI.MaxGuessesAllowed = 5;
        }
        else if (guessesSelectorDropdown.value == 1)
        {
            NumberGuessUI.MaxGuessesAllowed = 10;
        }
        else
        {
            NumberGuessUI.MaxGuessesAllowed = 15;
        }
    }
}
