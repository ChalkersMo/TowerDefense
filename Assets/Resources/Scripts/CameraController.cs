using UnityEngine;

using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10.0f;
    public float border = 10.0f;
    public float scrollSpeed = 2.0f;
    public float borderX1;
    public float borderX2;
    public float borderY1;
    public float borderY2;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.mousePosition.y >= Screen.height - border)
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= border)
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - border)
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= border)
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (pos.x < borderX1)
        {
            pos.x += speed * Time.deltaTime;
        }

        if (pos.x > borderX2)
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (pos.z < borderY1)
        {
            pos.z += speed * Time.deltaTime;
        }

        if (pos.z > borderY2)
        {
            pos.z -= speed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollSpeed * 100f * Time.deltaTime;

        transform.position = pos;
    }
}