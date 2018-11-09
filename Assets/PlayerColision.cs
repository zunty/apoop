using UnityEngine;

public class PlayerColision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("We hit " + collisionInfo.collider.name);

        if (collisionInfo.collider.name.Contains("Cube"))
        {
            Debug.Log("You Lost");
        }
    }

}
