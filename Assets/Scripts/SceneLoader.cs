using UnityEngine;
using UnityEngine.SceneManagement;

/*
 *  Attach to SceneLoader Empty Object in all Scenes
 *  In scenes: Start, CoreGame, ComputerWins, PlayerWins
 */
public class SceneLoader : MonoBehaviour
{
    // Called by SceneStart.ButtonStart, ScreneCoreGame.ComputerWinsButton
    public void LoadNextScene()
    {
        // Configure scene build index order in File | Build Settings
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Called by ButtonPlayAgain in ScenePlayerWins and SceneComputerWins
    public void LoadStartScene()
    {
        NumberGuessUI.MaxGuessesAllowed = 5;
        SceneManager.LoadScene(0);
    }

    // Called by SceneStart.ButtonQuitGame, SceneComputerWins.ButtonQuitGame, ScenePlayerWins.ButtonQuitGame
    public void OnPressButtonQuitGame()
    {
        Application.Quit();
    }


}
