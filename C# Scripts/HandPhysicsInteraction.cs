using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPresencePhysics : MonoBehaviour
{
    public Renderer ghostHand;
    public float ghostHand_distance = 0.05f;
    public Transform target;
    private Collider[] fingers;
    private Rigidbody hand_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        hand_rigidbody = GetComponent<Rigidbody>();
        fingers = GetComponentsInChildren<Collider>();
    }

    public void StartCollider()
    {
        foreach (var finger in fingers)
        {
            finger.enabled = true;
        }
    }

    public void ColliderTimeDelay(float timedelay)
    {
        Invoke("StartCollider", timedelay);
    }

    public void StopCollider()
    {
        foreach (var item in fingers)
        {
            item.enabled = false;
        }
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > ghostHand_distance)
        {
            ghostHand.enabled = true;
        }
        else
            ghostHand.enabled = false;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // position
        hand_rigidbody.velocity = (target.position - transform.position) / Time.fixedDeltaTime;

        //rotation
        Quaternion rotationDifference = target.rotation * Quaternion.Inverse(transform.rotation);
        rotationDifference.ToAngleAxis(out float angle, out Vector3 rotation);

        Vector3 rotation_Difference = angle * rotation;

        hand_rigidbody.angularVelocity = (rotation_Difference * Mathf.Deg2Rad / Time.fixedDeltaTime);
    }

}
