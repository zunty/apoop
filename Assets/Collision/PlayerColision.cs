using UnityEngine;

public class PlayerColision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("You Lost");
        }
    }

}
