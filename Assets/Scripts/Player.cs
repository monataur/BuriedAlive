using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    PlayerControls controls;

    public float[] gridHooks = new float[8];
    public int selectedHook = 0;

    public Transform caskett;
    public GameObject playerObject;

    public bool isFacingLeft = false;

    private Vector2 velocity = Vector2.zero;
    public float smoothTime;

    public float intervalSpeed = 2.5f;

    public AudioSource wurp;
    public AudioSource hammer;

    public GameObject gridObject;

    public int scaffoldCount;
    public int bombCount;
    public Text scaffoldText;
    public Text bombText;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.GridControls.MoveLeft.performed += _ => MoveLeft();
        controls.GridControls.MoveRight.performed += _ => MoveRight();
        controls.GridControls.PlaceScaffold.performed += _ => PlaceScaffold();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void Start()
    {
        StartCoroutine(TimerThing());
    }

    void Update()
    {
        switch (isFacingLeft)
        {
            case false:
                caskett.transform.eulerAngles = new Vector3(caskett.transform.rotation.x, 0, transform.rotation.z);
                break;

            case true:
                caskett.transform.eulerAngles = new Vector3(caskett.transform.rotation.x, 180, transform.rotation.z);
                break;
        }

        scaffoldText.text = $"Scaffold x{scaffoldCount}";
        bombText.text = $"Bomb x{bombCount}";
    }

    public void PlaceScaffold()
    {
        if(scaffoldCount >= 1)
        {
            switch (selectedHook)
            {
                case 0:
                    if(gridObject.GetComponent<GridStuff>().column0blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column0blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 1:
                    if (gridObject.GetComponent<GridStuff>().column1blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column1blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 2:
                    if (gridObject.GetComponent<GridStuff>().column2blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column2blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 3:
                    if (gridObject.GetComponent<GridStuff>().column3blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column3blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 4:
                    if (gridObject.GetComponent<GridStuff>().column4blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column4blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 5:
                    if (gridObject.GetComponent<GridStuff>().column5blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column5blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 6:
                    if (gridObject.GetComponent<GridStuff>().column6blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column6blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;

                case 7:
                    if (gridObject.GetComponent<GridStuff>().column7blocked == false)
                    {
                        gridObject.GetComponent<GridStuff>().column7blocked = true;
                        hammer.Play();
                        scaffoldCount -= 1;
                    }
                    break;
            }
            
        }
    }

    public void MoveLeft()
    {
        isFacingLeft = true;
        wurp.Play();

        switch (selectedHook)
        {
            case 0:
                break;

            case 1:
                selectedHook = 0;
                break;

            case 2:
                selectedHook = 1;
                break;

            case 3:
                selectedHook = 2;
                break;

            case 4:
                selectedHook = 3;
                break;

            case 5:
                selectedHook = 4;
                break;

            case 6:
                selectedHook = 5;
                break;

            case 7:
                selectedHook = 6;
                break;
        }
    }

    public void MoveRight()
    {
        isFacingLeft = false;
        wurp.Play();

        switch (selectedHook)
        {
            case 0:
                selectedHook = 1;
                break;

            case 1:
                selectedHook = 2;
                break;

            case 2:
                selectedHook = 3;
                break;

            case 3:
                selectedHook = 4;
                break;

            case 4:
                selectedHook = 5;
                break;

            case 5:
                selectedHook = 6;
                break;

            case 6:
                selectedHook = 7;
                break;

            case 7:
                break;
        }
    }

    float ProvideHookFloat(int num)
    {
        switch (num)
        {
            default:
                Debug.LogError("ProvideHookFloat() switched to default. Look into this.");
                return gridHooks[3];
            case 0:
                return gridHooks[0];
            case 1:
                return gridHooks[1];
            case 2:
                return gridHooks[2];
            case 3:
                return gridHooks[3];
            case 4:
                return gridHooks[4];
            case 5:
                return gridHooks[5];
            case 6:
                return gridHooks[6];
            case 7:
                return gridHooks[7];
        }
    }

    private void LateUpdate()
    {
        Vector2 newPos = new Vector2(ProvideHookFloat(selectedHook), caskett.position.y);

        caskett.position = Vector2.SmoothDamp(caskett.position, newPos, ref velocity, smoothTime);
    }

    IEnumerator TimerThing()
    {
        yield return new WaitForSeconds(7);
        intervalSpeed -= 0.1f;
        StartCoroutine(TimerThing());
    }
}
