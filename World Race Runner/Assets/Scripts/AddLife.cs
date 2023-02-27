
using UnityEngine;

public class AddLife : MonoBehaviour
{
    [SerializeField] private int addLife;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.TryGetComponent<PlayerMovement>(out var playerMovement))
            {
                playerMovement.ReceiveLife(addLife);
            }
            Destroy(gameObject,0.5f);
        }
    }
}

