using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timer=0;
    public int totalT=0;
    public Text txt;
    public Text txt2;
    private bool win = false;
    private GameObject[] targets;
  static  private float[] history = new float[5];
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("target");
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < targets.Length; i++)
        {
            if (i == 0)
            {
                totalT = 0;
            }
            if (targets[i].GetComponent<collsionTrigger>().hit == true)
            {
                totalT += 1;
            }
            if (totalT == targets.Length)
            {
                win = true;
            }

        }
        if (win == false)
        {
            timer += Time.deltaTime;
        }
        else
        {
            for(int i = 0; i < history.Length; i++)
            {
                if (history[i] > timer)
                {
                    history[i] = timer;
                    break;
                }
            }
            txt2.enabled = true;
        }

        txt.text = "Time Spend: "+ timer.ToString("F2");
    }
}
