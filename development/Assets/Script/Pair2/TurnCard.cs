using UnityEngine;
using UnityEngine.Tilemaps;

public class TurnCard : MonoBehaviour
{

    private MapManager _mapManager;
    private Tilemap _coverLayer;
    
    [SerializeField] 
    private AnimatedTile _openAnimation;
    [SerializeField]
    private AnimatedTile _closeAnimation;

    public Vector3Int ClickPos { get; set; }

    void Start()
    {
        _mapManager = GetComponent<MapManager>();
        _coverLayer = _mapManager.GetCoverLayer();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Turn(_mapManager.MapClickPosition);
        }
    }

    public void Turn(Vector3Int position)
    {
        _coverLayer.SetTile(position, _openAnimation);
    }
    
}
