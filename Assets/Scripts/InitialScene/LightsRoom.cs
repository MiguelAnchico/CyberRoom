using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;

[System.Serializable]
public class Tupe
{
    public Light light;
    public int time;
    public bool enabled = false;
    public float[] color;
    public float intensity;
}

public class LightsRoom : MonoBehaviour
{
    
    public List<Tupe> luces = new List<Tupe>();
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        int i = 0;

        foreach(Tupe tuple in luces)
        {
            if(tuple == null) {
                luces.RemoveAt(i);
            }
            if(tuple.time < timer) {
                tuple.light.color = new Color(tuple.color[0], tuple.color[1], tuple.color[2], tuple.intensity);
                if(tuple.light.range < 12f && tuple.enabled) {
                    tuple.light.range += 0.1f;
                }
                if(tuple.light.range > 2f && !tuple.enabled) {
                    tuple.light.range -= 0.1f;
                }

                if(tuple.light.range < 2f) {
                    tuple.enabled = true;
                }
                if(tuple.light.range > 12f) {
                    tuple.enabled = false;
                }
            }
            i++;
        }
    }
}
