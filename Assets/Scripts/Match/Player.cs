using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    private byte mana;
    private Hero hero;
    public byte Mana
    {
        get
        {
            return mana;
        }
    }
    public Hero Hero
    {
        get
        {
            return hero;
        }
    }
    public Player(bool firstTurn = false)
    {
        Init(firstTurn);
    }
    private void Init(bool firstTurn = false)
    {
        hero = new Hero();
        SetHeroHealth(Globals.DEFAULT_HERO_HEALTH);
        SetMana(firstTurn ? (byte)1 : (byte)0);
    }
    /// <summary>
    /// Set health to value
    /// </summary>
    /// <param name="value">New health value</param>
    private void SetHeroHealth(int value)
    {
        hero.Health = value;
    }
    /// <summary>
    /// Set mana to value
    /// </summary>
    /// <param name="value">New mana value</param>
    private void SetMana(byte value)
    {
        mana = value;
    }
    private void AddMana(byte amount)
    {
        if (mana + amount < byte.MaxValue)
        {
            mana += amount;
        }
        else
        {
            mana = byte.MaxValue;
        }
    }
}
