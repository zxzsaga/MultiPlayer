using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public Transform target;
    public float maxDistance = 1.5f;

    private float distance;

    void Update() {
        distance = Vector3.Distance(transform.position, target.position);
        if (distance > maxDistance) {
            transform.position = Vector3.MoveTowards(transform.position, target.position, distance - maxDistance);
        }
    }
}
