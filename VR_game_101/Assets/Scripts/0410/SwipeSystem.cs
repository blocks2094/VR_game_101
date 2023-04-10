using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    private Vector2 initiaIPos;
    public GameObject Character;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initiaIPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finaIPos)
    {
        float disX = Mathf.Abs(initiaIPos.x - finaIPos.x);
        float disY = Mathf.Abs(initiaIPos.y - finaIPos.y);

        if (disX > 0 || disY > 0)
        {
            if (disX > disY)
            {
                if (initiaIPos.x > finaIPos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            if (initiaIPos.y > finaIPos.y)
            {
                Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
            }

            else
            {
                Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
            }    
        }
    }
}
