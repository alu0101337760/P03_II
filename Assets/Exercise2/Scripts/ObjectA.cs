using UnityEditor.SceneManagement;
using UnityEngine;

public class ObjectA : MonoBehaviour
{
    public Material MatA, MatB;

    public GameObject objC;
    public float speed = 20f;
    public float jumpStrength;
    bool isMoving = false;
    void Start()
    {
        PlayerNotifier.instance.OnObjectB += GoToObjectC;
        PlayerNotifier.instance.OnObjectBExit += StopMoving;
        PlayerNotifier.instance.OnObjectC += ReactToC;
        objC = GameObject.FindWithTag("C");
    }

    void GoToObjectC()
    {
        isMoving = true;
    }

    void StopMoving()
    {
        isMoving = false;
    }

    void ReactToC()
    {
        Jump();
        ChangeColor();
    }

    void Jump()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpStrength, 0));
    }

    void ChangeColor()
    {
        Color currentColor = this.gameObject.GetComponent<MeshRenderer>().material.color;
        if (currentColor == MatA.color)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = MatB;
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = MatA;
        }

    }


    private void Update()
    {
        if (isMoving)
        {
            Vector3 target = objC.transform.position;
            Vector3 currentPos = this.gameObject.transform.position;
            if ((target - currentPos).magnitude > 3)
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(target.x - currentPos.x, 0, target.z - currentPos.z)* speed);
            }
        }
    }


}
