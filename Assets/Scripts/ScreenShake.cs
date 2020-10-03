using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    private Transform transform;
    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.2f;
    private float dampingSpeed = 0.15f;
    Vector3 initialPosition;

    [SerializeField]
    float shake;

    void Awake() {
        if (transform == null) {
            transform = GetComponent(typeof(Transform)) as Transform;
        }
    }

    void OnEnable() {
        initialPosition = transform.localPosition;
    }

    void Update() {
        if (shakeDuration > 0) {
            transform.localPosition = transform.position + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        } else {
            shakeDuration = 0f;
            transform.localPosition = transform.position;
        }
    }

    public void TriggerShake() {
        shakeDuration = shake;
    }

    void Start() {
    }
}
