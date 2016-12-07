using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

    public List<WavePart> wave = new List<WavePart>();
    public float timeToNextPartOfWave = 5f;
}
