using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    public static Player player;
    public static Player enemy;
    public static EventHandler NewTurn;
    public static EventHandler NewPlayerTurn;
    public static EventHandler NewEnemyTurn;
    void Awake()
    {
        bool firstTurn = UnityEngine.Random.Range(0, 2)==0?false:true;
        player = new Player(firstTurn);
        enemy = new Player(!firstTurn);
    }
	void Start ()
    {

	}
	void Update ()
    {
		
	}
}
