    using UnityEngine;

    public class CameraZoom : MonoBehaviour
    {
        public float zoomSpeed = 2f; // Adjust for desired zoom speed
        public float minOrthographicSize = 2f; // Minimum zoom level
        public float maxOrthographicSize = 10f; // Maximum zoom level

        void Update()
        {
            // Get input from mouse scroll wheel
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");

            // Adjust orthographic size based on input
            Camera.main.orthographicSize -= scrollDelta * zoomSpeed;

            // Clamp orthographic size to the allowed range
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minOrthographicSize, maxOrthographicSize);
        }
    }