using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementModel : MonoBehaviour 
{
    public float speed = 10f;

    Vector3 m_MovementDirection;



	void Start () 
	{
		
	}
	

	void Update () 
	{
        UpdateMovement();
	}

    void UpdateMovement()
    {
        if(m_MovementDirection == Vector3.zero)
        {
            return;
        }

        m_MovementDirection.Normalize();

        transform.position += m_MovementDirection * speed * Time.deltaTime;

    }
	
	public void SetDirection(Vector2 direction)
    {
        m_MovementDirection = new Vector3(direction.x, direction.y, 0);
    }

}
