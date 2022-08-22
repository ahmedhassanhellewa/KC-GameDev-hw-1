using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    string heroname = " Donald J. Trump ";
    int health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        print(" Welcome our hero " + heroname + " !! " + " your health is "  + health);
             dameged();
                    print(" You are being damaged , your health is " + dameged());
             boost();
        print(" You are recovering , your health now is " + boost () );

        if (dameged () > boost () )
        {
            print(dameged() + " is much more than " + boost ());
        }
        else
        {
        
            print(boost() + " is much more than " + dameged());
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    int dameged ()
    {
        return  health - 20;
    }

    int boost ()
    {
        return  dameged () + 10;


    }
























}
