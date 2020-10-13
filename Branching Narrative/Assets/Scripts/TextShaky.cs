using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextShaky : MonoBehaviour
{
        private float originalX;
	private float originalY;
        public float bobX = 0.1f;
        public float bobY = 0.2f;

            void Start(){
		this.originalY = this.transform.position.x;
                this.originalY = this.transform.position.y;
            }

            void Update()
            {
		float bobTempX = Random.Range (0.1f, 0.3f);
		float bobTempY = Random.Range (0.1f, 0.3f);
		bobX = bobTempX;
		bobY = bobTempY;

                  transform.position = new Vector2(originalX + ((float)Mathf.Sin(Time.time) * bobX),
                  originalY + ((float)Mathf.Sin(Time.time) * bobY));
            }
}
