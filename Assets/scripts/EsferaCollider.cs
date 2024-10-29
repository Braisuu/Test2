using UnityEngine;

public class EsferaCollider : MonoBehaviour
{
    public GameObject plano;
    [SerializeField] MeshRenderer myMesh;

    //VARIABLE TAG
    public string myTag = ""; 

    private void OnTriggerEnter(Collider other)
    {

        //ESTO ES PARA DESTRUIR LA ESFERA
        //Destroy(this.gameObject); 
        //ESTO ES PARA DESTRUIR EL OTRO OBJETO
        //Destroy(other.gameObject);
        //DESTRUIR OBJETO CONCRETO
        //Destroy(plano); 
        //DESTRUIR OBJETO VÍA NOMBRE

        /*if (other.gameObject.name == "Suelo")
        {
            Destroy(other.gameObject);
        }*/ 

        //DESTRUIR OBJETO VÍA TAG 

        if (other.gameObject.tag == "Obstaculo")
        {
            myMesh.enabled = false;
        }

        /*if (other.gameObject.CompareTag("Obstaculo")) 
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag(myTag))
        {
            Destroy(other.gameObject);
        }*/


        Debug.Log("Chocaste pendejo"); 
        Debug.Log(other.gameObject.name);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
