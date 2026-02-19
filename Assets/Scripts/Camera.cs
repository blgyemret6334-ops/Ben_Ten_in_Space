using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(target.position.x, target.position.y, -10);
    }
}
