using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rg;

    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rg.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rg.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }

    
}
