using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public float Speed = 5f;
    public GameObject FX;

    public void Spawn(GameObject potion)
    {
        GameObject newPotion = Instantiate(potion, SpawnPoint.position, Quaternion.identity);
        Rigidbody rb = newPotion.GetComponentInChildren<Rigidbody>();
        rb.isKinematic = false;
        rb.useGravity = true;
        rb.AddForce(new Vector3(0,1,-1)*Speed, ForceMode.Impulse);
        newPotion.transform.localScale = potion.transform.lossyScale;

        Instantiate(FX, SpawnPoint.position, Quaternion.identity);

    }
}
