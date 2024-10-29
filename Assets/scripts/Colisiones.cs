using UnityEngine;

public class Colisiones : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag=="Obstaculo")
        {
            Destroy(this.gameObject);
        }
    }
}
