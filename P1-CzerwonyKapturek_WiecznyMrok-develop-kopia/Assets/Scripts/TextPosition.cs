using UnityEngine;
using System.Collections;

public class TextPosition : MonoBehaviour
{
    //The item whose name should be shown
    public Transform target;
    [SerializeField] public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector2 targetPos = Camera.main.WorldToScreenPoint(target.position + offset);
            transform.position = targetPos;
        }

    }
}