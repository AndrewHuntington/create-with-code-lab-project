using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float speed = 10f;
  private float leftBoundary = -18.77f;
  private float rightBoundary = 17f;
  private float upperBoundary = 12.35f;
  private float lowerBoundary = -6.337812f;

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

    if (transform.position.x < leftBoundary)
    {
      transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
    }
    if (transform.position.x > rightBoundary)
    {
      transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
    }
    if (transform.position.y > upperBoundary)
    {
      transform.position = new Vector3(transform.position.x, upperBoundary, transform.position.z);
    }
    if (transform.position.y < lowerBoundary)
    {
      transform.position = new Vector3(transform.position.x, lowerBoundary, transform.position.z);
    }
  }
}
