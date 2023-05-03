using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Canvas")]
    public Canvas canvas;
    public TextMeshProUGUI winnerText;
    //public TextMeshProUGUI scoreTexts1;
    //public TextMeshProUGUI scoreTexts2;
    //public TextMeshProUGUI scoreTexts3;
    //public TextMeshProUGUI scoreTexts4;
    public GameObject[] players;
    public int winScore = 3;
    [Header("Sound")]
    public AudioSource audioSource;
    public AudioClip audioWin;
    

    public void Start()
    {
        int numberOfPlayer = GameSetting.NumberOfPlayers;
        if (numberOfPlayer == 2)
        {
            players[2].SetActive(false);
            players[3].SetActive(false);
            //scoreTexts2.gameObject.SetActive(false);
            //scoreTexts3.gameObject.SetActive(false);


        }
        else if (numberOfPlayer == 3)
        {
            players[3].SetActive(false);
            //scoreTexts3.gameObject.SetActive(false);

        }


    }
    public void CheckWinState()
    {
        //int score1 = 0;
        //int score2 = 0;
        //int score3 = 0;
        //int score4 = 0;
        int aliveCount = 0;
        GameObject lastPlayer = null;
        foreach (GameObject player in players)
        {
            if (player.activeSelf) {
                aliveCount++;
                lastPlayer = player;
            }
        }

        if (aliveCount <= 1) {
            string winnerName = lastPlayer.name;
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            winnerText.text = "Winner: " + winnerName;
            //int winnerIndex = System.Array.IndexOf(players, lastPlayer);
            //if (winnerIndex == 1)
            //{
            //    score1++;
            //    scoreTexts1.text = score1.ToString();
            //} else if(winnerIndex == 2)
            //{
            //    score2++;
            //    scoreTexts1.text = score2.ToString();
            //}
            //else if (winnerIndex == 3)
            //{
            //    score3++;
            //    scoreTexts1.text = score3.ToString();
            //}
            //else
            //{
            //    score4++;
            //    scoreTexts1.text = score4.ToString();
            //}
            audioSource.PlayOneShot(audioWin);
            //Invoke(nameof(NewRound), 3f);
        }


    }

    //public void NewRound()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
    public void OnClickPlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;


    }
    public void OnClickReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;

    }



}
