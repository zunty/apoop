using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rg;

    public int sidewaysForce = 700;
    public int forwardForce = 700;
    public int upwardForce = 3000;

    // Update is called once per frame
    void FixedUpdate()
    {
        rg.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
        {
            rg.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rg.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rg.AddForce(0, upwardForce * Time.deltaTime, 0);
        }

        if (rg.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    
}
