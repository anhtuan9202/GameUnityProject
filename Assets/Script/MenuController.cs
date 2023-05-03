using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject playGameCanvas;
    public GameObject playerSelectionCanvas;
    public void OnPlayGameButtonClicked()
    {
        playGameCanvas.SetActive(false);
        playerSelectionCanvas.SetActive(true);
    }
    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
    public void OnTwoPlayerButtonClicked()
    {
        int numberOfPlayers = 2;
        GameSetting.NumberOfPlayers = numberOfPlayers;
        SceneManager.LoadScene("GameScene");
    }
    public void OnThreePlayerButtonClicked()
    {
        int numberOfPlayers = 3;
        GameSetting.NumberOfPlayers = numberOfPlayers;
        SceneManager.LoadScene("GameScene");
    }
    public void OnFourPlayerButtonClicked()
    {
        int numberOfPlayers = 4;
        GameSetting.NumberOfPlayers = numberOfPlayers;
        SceneManager.LoadScene("GameScene");
    }

}
