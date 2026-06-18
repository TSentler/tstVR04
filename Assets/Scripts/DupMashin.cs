using UnityEngine;

public class SpawnerD : MonoBehaviour
{
    public PotionSpawner spawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            spawner.Spawn(other.gameObject);

        }
    }
}
