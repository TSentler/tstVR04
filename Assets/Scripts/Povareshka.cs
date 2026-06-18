using UnityEngine;

public class Povareshka : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "VODA")
        {
            print("есть контакт");
            FindAnyObjectByType<PotionSystem>().BrewPotion();
        }
    }
}
