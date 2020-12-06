using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Bumper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var translation = Input.GetAxis("Horizontal");

        // TODO: Limit bounds.
        transform.Translate(Vector3.right * translation);
    }
}
