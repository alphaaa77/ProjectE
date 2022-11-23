using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-5 * Time.deltaTime, 0);

        if(transform.position.x < -21.06)
        {
            transform.position = new Vector3(21.06f, transform.position.y);
        }
    }
}
