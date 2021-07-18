using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO deside wheather you want to make this system a 
//global sigalton where youse charicter + dialog depth to genarate the hash
//or if you want each charicter to hold there dialog 
public class dialogScriptManiger
{

    //is the main list of all the Dilog nodes
    public List<dialogNode> Dnodes;


    //constuctor called when first staring
    dialogScriptManiger()
    {
        //TODO this is where we will load and parse the Dialog JSON

        //The Json Shema is the shema for the dialog node class
    }
}
