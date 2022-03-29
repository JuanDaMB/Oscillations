using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillationManager : MonoBehaviour
{
    [SerializeField] private List<Oscilation> _oscilations;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Oscilation oscilation in _oscilations)
        {
            oscilation.SetUp(Random.Range(1f,5f),Random.Range(1f,5f),Random.Range(1f,5f),Random.Range(1f,5f));
        }
    }

}
