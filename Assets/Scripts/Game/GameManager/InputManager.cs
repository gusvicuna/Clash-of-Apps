using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameManager gameManager;
    public CountryBehaviour selectedCountry;
    public CountryBehaviour focusCountry;

    public LayerMask countryLayerMask;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.matchInfo.fase.Equals(GameFase.Attack)) {
            
            foreach (Touch touch in Input.touches) {
                if (touch.phase == TouchPhase.Began) {
                    RaycastHit hitInfo;
                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    if (Physics.Raycast(ray, out hitInfo, 100, countryLayerMask)) {
                        Debug.Log(hitInfo);
                        if (selectedCountry == null) {
                            selectedCountry = hitInfo.collider.gameObject.GetComponent<CountryBehaviour>();
                        }
                        else {
                            focusCountry = hitInfo.collider.gameObject.GetComponent<CountryBehaviour>();
                        }
                    }
                }
            }
        }
    }
}
