using UnityEngine;

public class InteractionButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "RedButton")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }

        if(collision.gameObject.tag == "RestartButton")
        {
            print("есть контакт");
            FindAnyObjectByType<GameManager>().RestartGame();
        }
    }
}
