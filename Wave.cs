using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject circlePrefab;
    public List<GameObject> circles;

    public int howManyCircles;

    [Range(1f, 10f)] public float amplitude;
    // Start is called before the first frame update
    void Start()
    {
        circles = new List<GameObject>();
        for (int i = 0; i < howManyCircles; i++)
        {
            GameObject circle = Instantiate(circlePrefab, transform);
            circles.Add(circle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < howManyCircles; i++)
        {
            float x = 0.6f * i;
            float y = amplitude * Mathf.Sin(i + Time.time);
            circles[i].transform.localPosition = new Vector3(x, y, 0);
        }
    }
}
