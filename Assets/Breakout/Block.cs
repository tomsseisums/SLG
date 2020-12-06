using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Block : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            gameObject.SetActive(false);
        }
    }
}
