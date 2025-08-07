using UnityEngine;
using UnityEngine.SceneManagement;

public class SessionController : MonoBehaviour
{
    public static SessionController Instance;

    [SerializeField] private GameObject gameOverPanel;

    void Awake()
    {
        // Singleton Pattern
        if (Instance == null)
            Instance = this;

        Time.timeScale = 1f;
    }

    public void TriggerGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}