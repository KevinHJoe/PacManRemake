using UnityEngine;

public class GhostMove : MonoBehaviour
{
    public Transform[] waypoints = new Transform[4];
    int cur = 0;

    public float speed = 8;

    private void Start()
    {
        speed = 8;
        Debug.Assert(waypoints.Length >= 0);
    }

    void FixedUpdate()
    {
        if (transform.position != waypoints[cur].position)
        {
            Vector3 p = Vector3.MoveTowards(transform.position, waypoints[cur].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(p);
        }
        else
        {
            cur = (cur + 1) % waypoints.Length;     //iterates through array and resets to 0 when cur%length = 0
        }

        speedIncrease();
    }

    public void speedIncrease()
    {
        int score = EatMe.score;
        if(score % 2230 == 0 && speed < 9)
        {
            speed += 0.2f;
        }
        else if(score % 2230 == 0 && speed > 9 && speed < 10)
        {
            speed += 0.1f;
        }
        else if(score % 2230 == 0 && speed > 10)
        {
            speed += 0.05f;
        }
    }
}
