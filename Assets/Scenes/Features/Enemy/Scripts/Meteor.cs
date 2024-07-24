using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public int speed;
    public int typ;
    public const int Scissors = 0;
    public const int Rock = 1;
    public const int Paper = 2;
    public Score scoreData;
    public Difficulty difficulty;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = difficulty.speed;
        typ = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward  * speed * Time.deltaTime;
    }
}
