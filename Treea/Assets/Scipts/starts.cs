using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starts : MonoBehaviour
{
    public GameObject star;
    public int numbers = 15;
    public float minX = 19f;
    public float minY = -25f;
    public float maxX = +75f;
    public float maxY = 15f;
    // Start is called before the first frame update
    void Start()
    {
       GenerateStars();    
        
    }
    void GenerateStars()
    {
        for (int i = 0; i < numbers; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            Instantiate(star, randomPosition,Quaternion.identity);
        }
    }
}
