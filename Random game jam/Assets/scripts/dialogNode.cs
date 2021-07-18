using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogNode 
{
    private int id;
    public int ID
    {
        get
        {
            return id;
        }
    }
    private string text;
    public string Text 
    {
        get
        {
            return text;
        }
    }
    private choise[] choises;
    public choise[] Choises
    {
        get
        {
            return choises;
        }
    }
    dialogNode(int _id,string _text,choise[] _choises)
    {
        id = _id;
        text = _text;
        choises = _choises;
    }
}


public struct choise {

    public choise(string text,int Id)
    {
        choiseTxt = text;
        nextId = Id;
    }

    public string choiseTxt { get; }
    public int nextId { get; }
}