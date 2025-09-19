using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timer = 120f;

    void Update()
    {
        timer -= Time.deltaTime;

      
        float displayTime = Mathf.Max(timer, 0f);
        timerText.text = "Time: " + displayTime.ToString("0.0");

        if (timer <= 0)
        {
            SceneManager.LoadScene("You Lose");
        }
    }
}