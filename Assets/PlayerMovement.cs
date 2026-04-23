using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        float moveX = 0f;
        float moveZ = 0f;

        // Klasik GetKey kullanarak Input System çakýþmasýný baypas ediyoruz
        if (Input.GetKey(KeyCode.W)) moveZ = 1f;
        if (Input.GetKey(KeyCode.S)) moveZ = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        Vector3 direction = new Vector3(moveX, 0f, moveZ).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        // Mekanik: Shift ile Dash
        if (Input.GetKeyDown(KeyCode.LeftShift)) moveSpeed = 15f;
        if (Input.GetKeyUp(KeyCode.LeftShift)) moveSpeed = 5f;
    }
}