using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    Transform playerTransform;

    public string HorizontalAxis = "Horizontal";
    public string VerticalAxis = "Vertical";


    void Start()
    {
        playerTransform = this.gameObject.transform;
    }


    void Update()
    {
        Vector3 pos = playerTransform.position;
        playerTransform.position = new Vector3(pos.x + Input.GetAxis(HorizontalAxis) * speed, pos.y, pos.z + Input.GetAxis(VerticalAxis) * speed);
    }
}
