using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = target.position - transform.position;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
            transform.position = target.position - offset;    
        
    }
}
