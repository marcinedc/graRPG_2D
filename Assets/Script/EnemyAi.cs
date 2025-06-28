using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private enum State {
        Roaming
    }

    private State state;
    private EnemyFollowPath enemyPathfinding;

    private void Awake() {
        enemyPathfinding = GetComponent<EnemyFollowPath>();
        state = State.Roaming;
    }

    private void Start() {
        StartCoroutine(RoamingRoutine());
    }

    private IEnumerator RoamingRoutine()
    {
    while (state == State.Roaming)
    {
        Vector2 roamPosition = GetRoamingPosition();
        enemyPathfinding.MoveTo(roamPosition);

        float timer = 0f; 
        float timeout = 3f;

        while (Vector2.Distance(transform.position, roamPosition) > 0.1f && timer < timeout)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        enemyPathfinding.StopMoving();
        yield return new WaitForSeconds(Random.Range(1f, 2f)); 
    }
    }

    [SerializeField] private LayerMask obstacleLayer;

    private Vector2 GetRoamingPosition()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            float distance = 1.5f;
            Vector2 candidate = (Vector2)transform.position + direction * distance;
            
            bool blocked = Physics2D.Raycast(transform.position, direction, distance, obstacleLayer);
            Debug.DrawLine(transform.position, candidate, blocked ? Color.red : Color.green, 300f);

            if(!blocked)
            {
                return (Vector2)transform.position + direction * distance;
            }

        }

        return transform.position;
    }

    

}
