using UnityEngine;

public class ObjectB : MonoBehaviour
{
    public GameObject beacon;
    public float growingFactor = 1.2f;

    void Start()
    {
        PlayerNotifier.instance.OnObjectA += IncrementSize;
        PlayerNotifier.instance.OnObjectC += LookTowardsBeacon;
        beacon = GameObject.FindWithTag("Beacon");
    }

    void IncrementSize()
    {
        this.gameObject.transform.localScale = this.gameObject.transform.localScale * growingFactor;
    }

    void LookTowardsBeacon()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward, Color.red, 10);
        this.gameObject.transform.LookAt(new Vector3(beacon.transform.position.x, 0, beacon.transform.position.z));
    }

    private void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.forward, Color.red);
    }

}
