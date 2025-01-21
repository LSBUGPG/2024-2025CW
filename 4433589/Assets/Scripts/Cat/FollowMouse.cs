using UnityEngine;

public class Merger : MonoBehaviour
{
    private bool _isBallDropped;
    
    private Rigidbody2D _rb;

    private readonly float _moveSpeed = 5.0f;
    
    [Header("Bounds")]
    private GameObject _box; 

    private Collider2D _ballCollider;
    private Collider2D _boxCollider;

    private float _halfBallWidth;
    private float _halfBoxWidth;
    
    private const float YClamp = 4.0f;

    void Start()
    {
        _box = GameObject.FindWithTag("BoxCollider");
        GetBounds();
        
        _rb = GetComponent<Rigidbody2D>();
        _isBallDropped = !Mathf.Approximately(transform.position.y, GameManager.Instance.ballSpawnLocation.y);
    }
    
    
    private void GetBounds()
    {
        // Get the ball's collider (make sure the ball has a 2D collider)
        _ballCollider = GetComponent<Collider2D>();

        // Get the box's collider (make sure the box has a 2D collider)
        _boxCollider = _box.GetComponent<Collider2D>();

        // Calculate half of the ball's width using the collider bounds
        _halfBallWidth = _ballCollider.bounds.extents.x;

        // Calculate half of the box's width using the collider bounds
        _halfBoxWidth = _boxCollider.bounds.extents.x;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) _isBallDropped = true;
        
        if (!_isBallDropped) FollowMouse();
        else DropBall();
    }
    
    private void FollowMouse()
    {
        /* Gets the mouse position in world space and then moves
        the ball to the x value of the mouse keeping the y locked. */
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(GameManager.Instance.mouseXPos.x, YClamp), _moveSpeed);

        ClampPosition();
    }

    private void ClampPosition()
    {
        Vector3 position = transform.position;
        
        float leftLimit = _boxCollider.bounds.center.x - _halfBoxWidth + _halfBallWidth;
        float rightLimit = _boxCollider.bounds.center.x + _halfBoxWidth - _halfBallWidth;

        position.x = Mathf.Clamp(position.x, leftLimit, rightLimit);

        transform.position = position;
    }
    
    private void DropBall()
    {
        _rb.simulated = true;
        Destroy(this);
    }
}