using UnityEngine;

public class Dragging : MonoBehaviour
{ 
 
 //this code is the same as the script ingredients but I used it to make my tutorials.
    private bool _dragging, _placed;
    [SerializeField] private GameObject resultItemPrefab; 
    [SerializeField] private Transform _slot; 

    private Vector2 _offset, _originalPosition;

    void Awake()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        if (_placed) return; 
        if (!_dragging) return; 

        var mousePosition = GetMousePos();
        transform.position = mousePosition - _offset; 
    }

    void OnMouseDown() 
    {
        _dragging = true;
        Debug.Log("Dragging started");

        _offset = GetMousePos() - (Vector2)transform.position; 
    }

    void OnMouseUp()
    {
        _dragging = false; 

      
        if (Vector2.Distance(transform.position, _slot.position) < 3)
        {
            transform.position = _slot.position;
            _placed = true; 

           
                if (resultItemPrefab != null)
                {
                    Instantiate(resultItemPrefab, _slot.position, Quaternion.identity);
                    Debug.Log("Result item instantiated");
                }
                else
                {
                    Debug.LogWarning("Result item prefab is not assigned!");
                }

         
            Destroy(gameObject);
        }
        else
        {
            transform.position = _originalPosition; 
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition); 
    }
}