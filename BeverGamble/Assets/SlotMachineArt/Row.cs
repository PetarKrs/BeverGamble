using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;
    void Start()
    {
        rowStopped = true;
        Click.ButtonClicked += StartRotating;
    }
    private void StartRotating() {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }
    private IEnumerator Rotate() { 
    rowStopped = false;
        timeInterval = 0.025f;
        for (int i = 1; i < 30; i++)
        {
            if (transform.position.y <= 14.56f) transform.position = new Vector2(transform.position.x, -14.7f);

            transform.position = new Vector2(transform.position.x, transform.position.y + 0.1672f);
            yield return new WaitForSeconds(timeInterval);  

        }
        //randomValue = Random.Range(60,100);
        randomValue = Random.Range(500, 834);

        switch (randomValue % 3) {
            case 1:
                randomValue += 2;
                break;
                case 2:
                randomValue += 1;
                break;
        }

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= 14.56f) transform.position = new Vector2(transform.position.x, -14.7f);

            transform.position = new Vector2(transform.position.x, transform.position.y + 0.1672f);

            if (i>Mathf.RoundToInt(randomValue * 0.1672f))
            {
                timeInterval = 0.05f;
            }
            if (i > Mathf.RoundToInt(randomValue * 0.3344f))
            {
                timeInterval = 0.1f;
            }
            if (i > Mathf.RoundToInt(randomValue * 0.5016f))
            {
                timeInterval = 0.15f;
            }
            if (i > Mathf.RoundToInt(randomValue * 0.6688f))
            {
                timeInterval = 0.2f;
            }

            yield return new WaitForSeconds(timeInterval);
        }
        if (transform.position.y == -14.7f)
            stoppedSlot = "Simi";
        else if (transform.position.y == -10.52f)
            stoppedSlot = "Baka";
        else if (transform.position.y == -6.34f)
            stoppedSlot = "Choda";
        else if (transform.position.y == -2.16f)
            stoppedSlot = "Bibi";
        else if (transform.position.y == 2.02f)
            stoppedSlot = "Janko";
        else if (transform.position.y == 6.2f)
            stoppedSlot = "Lacku";
        else if (transform.position.y == 10.38f)
            stoppedSlot = "Masnokosi";
        else if (transform.position.y == 14.56f)
            stoppedSlot = "Simi";

        rowStopped = true;
    }
    void Update()
    {
        
    }
}
