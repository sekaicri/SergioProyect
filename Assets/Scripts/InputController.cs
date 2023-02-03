
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Transform cam;
    [SerializeField]
    private Joystick joystickGiro;
    [SerializeField]
    private Transform player;
    [SerializeField]
    private CharacterController controller;

    
    float rotateV;
    float rotateH;
    public float speedGiro = 0.2f;
   
    private void Start()
    {
        cam = Camera.main.transform;
    }
    private void Update()
    {
        Rotate();
    }
   

    void Rotate()
    {
        rotateH = joystickGiro.Horizontal * speedGiro;
        rotateV = -(joystickGiro.Vertical * speedGiro);
        cam.Rotate(rotateV, 0, 0);
        player.Rotate(0, rotateH, 0);
    }

   
}
