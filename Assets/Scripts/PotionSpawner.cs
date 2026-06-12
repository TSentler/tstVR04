using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public float Speed = 5f;

    public void Spawn(GameObject potion)
    {
        GameObject newPotion = Instantiate(potion, SpawnPoint.position, Quaternion.identity);
        newPotion.GetComponentInChildren<Rigidbody>().AddForce(new Vector3(0,1,-1)*Speed, ForceMode.Impulse);
    }
}
