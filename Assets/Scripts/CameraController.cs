using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;  // 따라갈 대상
    public Vector3 offset = new Vector3(0, 0, -10f); // 카메라가 플레이어보다 뒤쪽에 있도록 위치 보정

    public float followSpeed = 5f; // 따라가는 속도

    void LateUpdate()
    {
        if (target == null) return;

        // 부드럽게 따라가기 (선형 보간)
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}
