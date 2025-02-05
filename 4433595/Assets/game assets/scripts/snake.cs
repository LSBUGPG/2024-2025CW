using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class snake : MonoBehaviour
{
     
   private Vector2 _directions = Vector2.right;
  

   private List<Transform> _segments = new List<Transform>();
   public Transform segmentPrefab;
   public int initialSize = 4;


   private void Start()
   {
       ResetState();

   }


   private void Update()
   {
     if (Input.GetKeyDown(KeyCode.W)){
        _directions = Vector2.up;
     } else if (Input.GetKeyDown(KeyCode.S)){
        _directions = Vector2.down;
     } else if (Input.GetKeyDown(KeyCode.A)){
        _directions = Vector2.left;
     } else if (Input.GetKeyDown(KeyCode.D)){
        _directions = Vector2.right;
     }
   }
   private void FixedUpdate()
   {
       for (int i = _segments.Count - 1; i > 0; i --)
       {
           _segments[i].position = _segments[i- 1].position;
       }
    
    this.transform.position = new Vector3(
        Mathf.Round(this.transform.position.x) + _directions.x,
        Mathf.Round(this.transform.position.y) + _directions.y,
        0.0f
    );
   }
   
      private void Grow()
      {
         Transform segment = Instantiate(this.segmentPrefab);
         segment.position = _segments[_segments.Count - 1] .position;

         _segments.Add(segment);
      }


        private void ResetState()
        {
          for(int i = 1; i < _segments.Count;  i++) {
            Destroy(_segments[i].gameObject);
          }

          _segments.Clear();
          _segments.Add(this.transform);
          this.transform.position = Vector3.zero;

          for (int i = 1; i<this.initialSize; i++){
            _segments.Add(Instantiate(this.segmentPrefab));
          }

          

        }


            private void OnTriggerEnter2D(Collider2D other)
            {
               if (other.tag == "Food"){
                  Grow();
               } else if (other.tag == "Obstalce") {
                  ResetState();
               }
            }
}

