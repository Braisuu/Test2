using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Personaje ObjetoPersonaje;
    private Personaje myScript;
    void Start()
    {
        //ME PERMITE ACCEDER A UNA VARIALBLE DE OTRO SCRIPT
        print(myScript.ammo);
        //ME PERMITE ACCEDER A UNA MÉTODO DE OTRO SCRIPT
        myScript.ammo = 100;
        myScript.SendMessage("UpdateText");
        print(myScript.ammo);
        myScript= ObjetoPersonaje.GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
