using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilation : MonoBehaviour
{
    [Header("Oscillation X")]
    [SerializeField, Range (0f,10f)] private float periodX;
    [SerializeField, Range (0f,10f)] private float amplitudeX;
    [Header("Oscillation Y")]
    [SerializeField, Range (0f,10f)] private float periodY;
    [SerializeField, Range (0f,10f)] private float amplitudeY;

    public void SetUp(float pX, float aX, float pY, float aY)
    {
        periodX = pX;
        amplitudeX = aX;
        periodY = pY;
        amplitudeY = aY;
    }
    private void Update()
    {
        float factorX = Time.time / periodX;
        float x = amplitudeX * Mathf.Sin(Mathf.PI*2 * factorX);
        float factorY = Time.time / periodY;
        float y = amplitudeY * Mathf.Sin(Mathf.PI*2 * factorY);

        Vector3 position = transform.position;
        position = new Vector3(x, y, position.z);
        transform.position = position;
    }
}
