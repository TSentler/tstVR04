using UnityEngine;

public class Golf : MonoBehaviour
{
     public Transform SpawnPoint;
    public GameObject FX;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "W")
        {
            print("есть контакт");
            Instantiate(FX, SpawnPoint.position, Quaternion.identity);
        }
    }
}
