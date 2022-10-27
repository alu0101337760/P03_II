using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace II
{
    public class Manager : MonoBehaviour
    {
        public delegate void doStuff();
        public event doStuff OnNotification;
        public int counter = 0;

        public static Manager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        void Update()
        {
            counter++;
            if (counter >= 100)
            {
                OnNotification();
                counter = 0;
            }

        }
    }
}