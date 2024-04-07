using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOverTime1 : MonoBehaviour
{
    public float scaleFactorX = 0.01f; // Adjust the scale factor on the x-axis as needed

    void Update()
    {
        // Increase the scale of the object over time on the x-axis
        transform.localScale += new Vector3(0f, 0f, scaleFactorX * Time.deltaTime);
    }
}
