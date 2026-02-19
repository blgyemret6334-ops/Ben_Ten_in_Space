using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(target.position.x, target.position.y, -10);
    }
}
