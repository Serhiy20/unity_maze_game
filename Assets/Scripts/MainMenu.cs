using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource clicking;
    public void PlayLevel1()
    {
        clicking.Play();
        SceneManager.LoadSceneAsync(1);
    }
    public void PlayLevel2()
    {
        clicking.Play();
        SceneManager.LoadSceneAsync(2);
    }
    public void PlayLevel3()
    {
        clicking.Play();
        SceneManager.LoadSceneAsync(3);
    }
    public void QuitGame()
    {
        clicking.Play();
        Application.Quit();
    }
}
