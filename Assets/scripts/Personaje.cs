using TMPro;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public TMP_Text myText;
    public float ammo;
    void Start()
    {
        UpdateText();
        
    }

    public void UpdateText()
    {
        myText.text = "Ammo: " + ammo;
    }
    void Update()
    {
        
    }
}
