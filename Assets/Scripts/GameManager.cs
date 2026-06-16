using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public int score = 0;
   public Text scoreText;

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

	}
}
