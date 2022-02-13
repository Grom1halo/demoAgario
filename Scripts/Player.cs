using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player playerCopy;
    //public Food food;

    public float bifurcationDistance = 1;
    public float Speed;
    public float Increase = 0.1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Bifurcation();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Food>())
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);
        }
    }

    private void Bifurcation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.localScale += new Vector3(transform.localScale.x / -2, transform.localScale.y / -2, transform.localScale.z / -2);


        }
    }

    private void Move()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed / transform.localScale.x * Time.deltaTime);
    }
}
