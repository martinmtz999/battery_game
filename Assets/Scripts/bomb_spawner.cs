using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{

    public GameObject itemPrefab;
    public float r;

    // Start is called before the first frame update
    void Start()
    {  
        
        for(int i = 0; i < 5; i++)
        {
            spawObject(); 
        }
        Vector3 randomPos = Random.insideUnitCircle * r + new Vector2(-10, 0);

    }

    // Update is called once per frame
    void Update()
    {
       // if(Input.GetKeyDown(KeyCode.B))
       // {
         //   spawObject();
       // }
    }

    void spawObject()
    {

        Vector3 randomPos = Random.insideUnitCircle * r;
        Instantiate(itemPrefab,randomPos,Quaternion.identity);

    }
}
