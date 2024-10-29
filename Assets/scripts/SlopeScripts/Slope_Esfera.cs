using UnityEngine;

public class Slope_Esfera : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    [SerializeField] float force;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float desplY = Input.GetAxis("Jump");
        rb.AddForce(Vector3.up * jumpForce * Time.deltaTime * desplY);
    }
}
