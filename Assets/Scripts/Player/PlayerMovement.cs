using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isGameFinish;

    [SerializeField] private bool smoothIncrease;

    [SerializeField] private float speed;
    [SerializeField] private float horizontalSpeed;

    [SerializeField] private float minValue;
    [SerializeField] private float maxValue;

    [SerializeField] private float increaseDelay;

    private float horizontalVector;
    private float extraSpeed = 1;

    private float timer;
    // Start is called before the first frame update
    private void Awake()
    {
        timer = increaseDelay;
    }
    // Update is called once per frame
    void Update()
    {
       if(isGameFinish != true)
        {
            if (smoothIncrease)
            {
                extraSpeed += Time.deltaTime / increaseDelay;
            }
            else
            {
                timer -= Time.deltaTime;

                if (timer < 0)
                {
                    extraSpeed += 1;
                    timer = increaseDelay;
                }
            }


            horizontalVector = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.forward * speed * extraSpeed * Time.deltaTime);

            if (horizontalVector != 0)
            {
                transform.Translate(Vector3.right * horizontalVector * extraSpeed * horizontalSpeed * Time.deltaTime);

                Vector3 playerPositon = transform.position;

                playerPositon.x = Mathf.Clamp(playerPositon.x, minValue, maxValue);

                transform.position = playerPositon;
            }
        }
        


        //print(horizontalVector);
    }
}
