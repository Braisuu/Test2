using UnityEngine;

public class Esfera : MonoBehaviour
{
    [SerializeField] float force;
    public float speed;
    public float jumpForce;
    private Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed);
        Debug.Log(Input.GetAxis("Vertical"));
        transform.Translate(Vector3.forward * desplY * Time.deltaTime * speed);

    }
}
