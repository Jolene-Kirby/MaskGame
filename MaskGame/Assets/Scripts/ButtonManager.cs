using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject GameSpaceScreen;
    public GameObject GameOverScreen;

    public void StartGame()
    {
        StartScreen.SetActive(false);
        GameSpaceScreen.SetActive(true);
    }

    public void Restart()
    {
        GameSpaceScreen.SetActive(true);
        GameOverScreen.SetActive(false);
    }
}
