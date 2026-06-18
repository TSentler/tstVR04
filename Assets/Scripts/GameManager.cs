using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public int score = 0;
   public TMP_Text scoreText;

	void Start()
	{
		UpdateScoreUI();
	}

	void UpdateScoreUI()
	{
		scoreText.text = "Score: " + score;
	}

   public void AddScore()
   {
	   score +=10;
	   Debug.Log("Очки: " + score);
		UpdateScoreUI();
   }

   public void RemoveScore()
   {
	   score -=5;
	   Debug.Log("Очки: " + score);
        UpdateScoreUI();
    }

	public void RestartGame()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
