using UnityEngine;

public class CuboideMovement : MonoBehaviour {

    public Rigidbody rg;

    public int upwardForce = 800;
    public int frameCounter = 0;

    private void Start()
    {
        rg = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate () {
        rg.AddForce(0, upwardForce * Mathf.Sin(frameCounter/20) * Time.deltaTime, 0);
        frameCounter++;
	}
}
