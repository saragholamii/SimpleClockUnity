using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;   
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;

public class Clock : MonoBehaviour
{
    const float hoursToDegree = -30f;
    const float minutToDegree = -6f;
    const float secoundToDegree = -6f;
    [SerializeField]
    Transform hoursPivot, minutsPivot, secoundPiovt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegree * (float) time.TotalHours);
        minutsPivot.localRotation = Quaternion.Euler(0f, 0f, minutToDegree * (float) time.TotalMinutes);
        secoundPiovt.localRotation = Quaternion.Euler(0f, 0f, secoundToDegree * (float) time.TotalSeconds);
    }
}
