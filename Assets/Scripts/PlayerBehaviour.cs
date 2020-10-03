using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    [SerializeField]
    float speed = 1f;

    [SerializeField]
    GameObject camera;

    float verticalMove = 0f;
    float horizontalMove = 0f;
    bool clicked = false;



    CharacterController character;

    void Start() {
        this.gameObject.AddComponent<CharacterController>();
        character = GetComponent<CharacterController>();

        
    }

    void Update() {
        verticalMove = Input.GetAxisRaw("Vertical") * speed;
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if(Input.GetMouseButtonDown(0) && clicked == false) {
            clicked = true;
            camera.GetComponent<ScreenShake>().TriggerShake();

        }

        if(Input.GetMouseButtonUp(0) && clicked == true) {
            clicked = false;
        }



    }

    void FixedUpdate() {


        character.Move(new Vector3(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime, 0));

    }

    

}