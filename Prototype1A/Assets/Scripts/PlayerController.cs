using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 40f;

    public float horizontalInput = 0;
    public wfloat verticalInput = 0;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
// Seit es gribu uzrakstit kodu, kas manu masinu kustinas katra freima nedaudz uz prieksu
//V.forward = 1 metrs uz prieksu
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //20 meter / second
//Mes rotejam objektu ap iesminu, kas skatas uz augsu
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput); //20 meter / second
//kept jus tin case
//transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); //20 meter / second
    }
}