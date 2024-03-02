using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Attached to Empty Game Object in SceneCoreGame
 */
public class NumberGuessUI : MonoBehaviour
{
    [SerializeField] int maximumGuessValue;
    [SerializeField] int minimumGuessValue;
    [SerializeField] TextMeshProUGUI guessesCurrentValueText;
    [SerializeField] TextMeshProUGUI guessesRemainingCountText;
    int currentGuessValue;
    public static int MaxGuessesAllowed = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        NextGuess();
    }
    // Called by SceneCoreGame.ButtonGuessHigher
    public void OnPressButtonGuessHigher()
    {
        maximumGuessValue = currentGuessValue - 1;
        NextGuess();
    }
    // Called by SceneCoreGame.ButtonGuessLower
    public void OnPressButtonGuessLower()
    {
        minimumGuessValue = currentGuessValue + 1;
        NextGuess();
    }
    public void NextGuess()
    {
        // Create a random value
        currentGuessValue = UnityEngine.Random.Range(minimumGuessValue, maximumGuessValue + 1);
        guessesCurrentValueText.text = currentGuessValue.ToString();
        guessesRemainingCountText.text = MaxGuessesAllowed.ToString();
        MaxGuessesAllowed -= 1;
        // If computer runs out of guesses then the player wins
        if (MaxGuessesAllowed <= -1)
        {
            SceneManager.LoadScene("ScenePlayerWins");
        }
    }
    /* 
    The video was REALLY long. I very much appreciate the work that went into it, but it felt like it could have been broken up into smaller videos. I think that would allow students to more concisely move through the assignment. Totally an aside, the Panopto video player itself is a bit lackluster.
    
    There was a ton of great information in the video, but it felt a bit unwieldy to me. Breaking up the video into smaller components to me I think would allow students to follow along bit better, similarly to how we want code to broken up into smaller readable chunks. Luckily I did not run into any issues in this instance, but I could imagine that something so large something could be easily missed and backtracking through it could be difficult.

    Being totally new to Unity, getting my bearings was surprisingly quick, so I think the video did a good job of getting students. Seeing Unity's functionality was also very interesting. I didn't think the calling functions from a script would be so straightforward but it was, which was nice surprise. Again, I'm pretty impressed with Unity. It seems like a neat tool for games and simulation. I'm also very much seeing the importance of good organization, naming conventions, coding best practices, and things of that nature as projects grow in size and complexity.
     */

}