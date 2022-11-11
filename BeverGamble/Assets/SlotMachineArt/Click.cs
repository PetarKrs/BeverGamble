using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Click : MonoBehaviour
{
    public static event Action ButtonClicked = delegate { };

    [SerializeField]
    private Text prizeText;

    [SerializeField]
    private Row[] rows = new Row[3];

    private int prizeValue;

    private bool resultsChecked = false;


    void Update()
    {
        if (!rows[0].rowStopped || rows[1].rowStopped || rows[2].rowStopped) 
        { 
            prizeValue = 0;
            resultsChecked = false;
            prizeText.enabled = false;  
        }
        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped)
        {
            CheckResults();
            Debug.Log(prizeText.text);
            prizeText.enabled = true;
            prizeText.text = "Prize: " + prizeValue;
        }

    }

    private void OnMouseDown()
    {
        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped)
            ButtonClicked();
           
    }

    private void CheckResults()
    {
        if (rows[0].stoppedSlot.Equals(rows[1].stoppedSlot) && rows[0].stoppedSlot.Equals(rows[2].stoppedSlot))
        {
            switch (rows[0].stoppedSlot)
            {
                case "Masnokosi":
                    prizeValue = -100;
                    break;

                case "Lacku":
                    prizeValue = 300;
                    break;
                case "Janko":
                    prizeValue = 500;
                    break;
                case "Choda":
                    prizeValue = 700;
                    break;
                case "Baka":
                    prizeValue = 1000;
                    break;
                case "Bibi":
                    prizeValue = 1500;
                    break;
                case "Simi":
                    prizeValue = 2000;
                    break;
               
            }
        }
        if (rows[0].stoppedSlot.Equals(rows[1].stoppedSlot) && !rows[0].stoppedSlot.Equals(rows[2].stoppedSlot) || !rows[0].stoppedSlot.Equals(rows[1].stoppedSlot) && rows[0].stoppedSlot.Equals(rows[2].stoppedSlot)|| !rows[0].stoppedSlot.Equals(rows[1].stoppedSlot) && rows[0].stoppedSlot.Equals(rows[2].stoppedSlot))
        {
            switch (rows[0].stoppedSlot)
            {
                case "Masnokosi":
                    prizeValue = -20;
                    break;

                case "Lacku":
                    prizeValue = 100;
                    break;
                case "Janko":
                    prizeValue = 200;
                    break;
                case "Choda":
                    prizeValue = 400;
                    break;
                case "Baka":
                    prizeValue = 600;
                    break;
                case "Bibi":
                    prizeValue = 1500;
                    break;
                case "Simi":
                    prizeValue = 2000;
                    break;
               
            }
        }
        resultsChecked = true;
    }
   
}
   
   

