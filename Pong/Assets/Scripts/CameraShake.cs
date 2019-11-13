using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public float Seconds;
    public float Offset;
    public float Scale;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = Seconds + Offset;
    }

    public void Reset()
    {
        time = Offset;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(time < Seconds + Offset)
        {
            time += Time.deltaTime;
            float amt = 1 / (time * time) * Scale;
            Vector2 pos = Random.insideUnitCircle * amt;
            gameObject.transform.position = new Vector3(pos.x, pos.y, -10);
        } else
        {
            gameObject.transform.position = new Vector3(0, 0, -10);
        }
    }
}
