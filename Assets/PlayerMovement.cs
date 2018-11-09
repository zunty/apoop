using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rg;

    public int sidewaysForce = 500;
    public int upwardForce = 5000;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("s"))
        {
            rg.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rg.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

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
    }

    
}
