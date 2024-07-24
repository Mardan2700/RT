using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject meteor;

    public Transform[] points;

    public float intervall;

    private float timer;


    public Difficulty difficulty;
    
    void Start()
    {
        intervall = difficulty.intervall;
        
    }
    
    
    
    void Update()
    {
        if (timer > intervall)
        {
            GameObject spawnedmeteor = Instantiate(meteor, points[Random.Range(0, points.Length)].position,quaternion.identity);
            timer -= intervall;
        }

        timer += Time.deltaTime;
    }
}
