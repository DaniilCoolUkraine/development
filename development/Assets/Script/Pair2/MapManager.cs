using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{

    [SerializeField] 
    private Tilemap _coverLayer;

    [SerializeField] 
    private Camera _mainCamera;
    
    public Vector3Int MapClickPosition { get; private set; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MapClickPosition = GridClickPosition(Input.mousePosition);
        }
    }

    private Vector3Int GridClickPosition(Vector3 mousePos)
    {
        Vector3 clickPos;
        Vector3Int res;
        
        clickPos = _mainCamera.ScreenToWorldPoint(mousePos);
        res = _coverLayer.WorldToCell(clickPos);
        
        return res;
    }

    public Tilemap GetCoverLayer() => _coverLayer;

}
