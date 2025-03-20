using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefSpawner : MonoBehaviour
{
    public GameObject thief;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Vector3 position = new(Random.Range(-45, 45), 0, Random.Range(-45, 45));
            Instantiate(thief, position, Quaternion.identity);
        }
    }
}
