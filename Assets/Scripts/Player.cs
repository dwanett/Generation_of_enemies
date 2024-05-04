using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Vector3 _directionMove;

    private void Awake()
    {
        _directionMove = Vector3.zero;
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(_speed * Time.deltaTime * _directionMove);
    }
    
    public void SetDirectionMove(Vector3 directionMove)
    {
        _directionMove = directionMove;
    }
}
