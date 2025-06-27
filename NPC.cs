using System;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPC : MonoBehaviour 
{
    public int health=5;
    public float speed = 0f;
    public int level = 1;
    bool move;
    void Start()
    {
        move= false;
    }
    void Update()
    {
        if (move==true)
        {
            speed = 1.2;
        }
        
    }
}
