using UnityEngine;

namespace II
{
    public class Subscriber : MonoBehaviour
    {
        public Material MatA, MatB;

        void Start()
        {
            Manager.instance.OnNotification += Answer;

        }

        void Answer()
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
    }
}