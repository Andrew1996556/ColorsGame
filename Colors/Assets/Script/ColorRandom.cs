using UnityEngine;
using System.Collections;

public class ColorRandom : MonoBehaviour
{

    
    void Start()
    {
        StartCoroutine("ChangeColor");
    }

    IEnumerator ChangeColor()
    {
        Material material = this.GetComponent<Renderer>().material;
        while (true)
        {
            material.color = new Color(Random.value, Random.value, Random.value, 5);
            yield return new WaitForSeconds(10f);
        }
    }

}


