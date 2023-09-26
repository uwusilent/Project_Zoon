using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureProfile : MonoBehaviour
{
    [Header("Summary")]
    public string name;
    public string nature;
    public string currentXP;
    private string nextLvlXP;

    [Header("Base Stats")]
    public int hp;
    public int attack;
    public int defense;
    public int SPattack;
    public int SPdefense;
    public int speed;

   // [Header("Habilities")]
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
