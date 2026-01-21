using UnityEngine;

public class parallax : MonoBehaviour
{
    public Transform camara;
    [Range(0f, 1f)]
    public float efectoParallax; // 0 = no se mueve, 1 = se mueve igual que la cámara

    private Vector3 posicionAnteriorCamara;

    void Start()
    {
        posicionAnteriorCamara = camara.position;
    }

    void LateUpdate()
    {
        Vector3 deltaMovimiento = camara.position - posicionAnteriorCamara;
        transform.position += new Vector3(
            deltaMovimiento.x * efectoParallax,
            deltaMovimiento.y * efectoParallax,
            0
        );

        posicionAnteriorCamara = camara.position;
    }
}
