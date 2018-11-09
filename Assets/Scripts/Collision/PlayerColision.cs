using UnityEngine;

public class PlayerColision : MonoBehaviour {

    public PlayerMovement movement;
    public EnemyMovement movement2;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("You hit an obstacle");
        }

        if (collisionInfo.collider.tag == "Enemy")
        {
            movement.enabled = false;
            movement2.enabled = false;
            Debug.Log("You Lost");
        }
    }

}
