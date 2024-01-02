using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float speed = 10f;
  private float leftBoundary = -18.77f;
  private float rightBoundary = 17f;
  private float upperBoundary = 12.35f;
  // may need to adjust once ground is added
  private float lowerBoundary = -5f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
    transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Enemy"))
    {
      Debug.Log("CRASH!");
    }
  }
}