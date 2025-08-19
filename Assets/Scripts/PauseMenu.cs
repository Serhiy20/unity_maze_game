using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject finishMenuUI;
    public AudioSource clicking;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        finishMenuUI.SetActive(false);
        gamePaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused && !finishMenuUI.activeSelf)
            {
                Resume();
            }
            else if (!gamePaused && !finishMenuUI.activeSelf)
            {
                Pause();
            }
        }
    }

    public void Home()
    {
        clicking.Play();
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        clicking.Play();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }
    public void Restart()
    {
        clicking.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Pause()
    {
        clicking.Play();
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
}
