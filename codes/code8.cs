using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel;  // Assign the Game Over UI panel in Inspector
    private bool isGameOver = false;

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);  // Hide the panel at start
    }

    void Update()
    {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Game"); // Reload current scene
            }
            else if (Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene("MainMenu"); // Load main menu scene
            }
        }
    }

    public void ShowGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);   // Show Game Over panel

        isGameOver = true; // Enable input listening
    }
}