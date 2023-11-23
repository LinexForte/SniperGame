using UnityEngine;

public struct Hit
{
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 direction;
    public float speed;
    public RaycastHit raycastHit;

    public Hit(Vector3 startPoint, Vector3 endPoint, Vector3 direction, float speed, RaycastHit raycastHit)
    {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
        this.direction = direction;
        this.speed = speed;
        this.raycastHit = raycastHit;
    }
}