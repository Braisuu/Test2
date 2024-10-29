using UnityEngine;

public class RandomRange : MonoBehaviour
{
    //CREO UN ARRAY DE TIPO GAMEOBJECT
    [SerializeField] GameObject[] assets = new GameObject[7];

    //CREAMOS UN VECTOR DE POSICIÓN
    public Vector3 initPos = new Vector3(-5, 0, 0);
    void Start()
    {
        //Debug.Log(assets[0]);
        Debug.Log(Random.Range(0, 10));
        for (int i = 0; i < assets.Length; i++)
        {

            //RANDOM RANGE
            int r = Random.Range(0, assets.Length);


            Instantiate(assets[r], initPos,Quaternion.Euler(0,180,0));

            //LOS SEPARAMOS UNOS DE OTROS SUMANDO UN NUVEO VECTOR
            initPos = initPos + new Vector3(Random.Range(0,10), 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Random.Range(0, 10));
    }
}
