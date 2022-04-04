// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GridControls"",
            ""id"": ""cca36a0f-a6b1-4ca1-b3dc-34a2b1b440f2"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""48d5fd92-b202-4098-8fab-99417bd969d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""d519f520-01e4-45fe-9b1a-b943ffed9f62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlaceScaffold"",
                    ""type"": ""Button"",
                    ""id"": ""56e949ed-f050-49f0-80fd-0d7688fdadff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""32ffcfe0-3bc3-4586-85f0-d19672ca1f4c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33d38fff-4bad-4aea-8423-8bc6bea71d55"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""248e577b-589b-43c5-a4d8-b253b398ed97"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72157421-525d-4052-8021-032e3dc09d42"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5b06428-1a51-4bb9-a3b8-333a029e4ed8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""641a326b-9c28-427e-b56c-05a41d16df8c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e76587e-5ead-439b-a1be-33058ebe9c31"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49f5f2aa-3d9f-4a4e-bab3-2aa23225d61b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d7a4c49-2f5e-4eda-a0fc-19303bb8722d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceScaffold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""131c7fd4-8899-4dcb-8180-09f574f05d5e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceScaffold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d2448b2-cdcc-4200-8c02-351c75eab62b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceScaffold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a1a80a7-a1a2-45c3-9f1e-58ce1126c143"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceScaffold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GridControls
        m_GridControls = asset.FindActionMap("GridControls", throwIfNotFound: true);
        m_GridControls_MoveLeft = m_GridControls.FindAction("MoveLeft", throwIfNotFound: true);
        m_GridControls_MoveRight = m_GridControls.FindAction("MoveRight", throwIfNotFound: true);
        m_GridControls_PlaceScaffold = m_GridControls.FindAction("PlaceScaffold", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GridControls
    private readonly InputActionMap m_GridControls;
    private IGridControlsActions m_GridControlsActionsCallbackInterface;
    private readonly InputAction m_GridControls_MoveLeft;
    private readonly InputAction m_GridControls_MoveRight;
    private readonly InputAction m_GridControls_PlaceScaffold;
    public struct GridControlsActions
    {
        private @PlayerControls m_Wrapper;
        public GridControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_GridControls_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_GridControls_MoveRight;
        public InputAction @PlaceScaffold => m_Wrapper.m_GridControls_PlaceScaffold;
        public InputActionMap Get() { return m_Wrapper.m_GridControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GridControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGridControlsActions instance)
        {
            if (m_Wrapper.m_GridControlsActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnMoveRight;
                @PlaceScaffold.started -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnPlaceScaffold;
                @PlaceScaffold.performed -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnPlaceScaffold;
                @PlaceScaffold.canceled -= m_Wrapper.m_GridControlsActionsCallbackInterface.OnPlaceScaffold;
            }
            m_Wrapper.m_GridControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @PlaceScaffold.started += instance.OnPlaceScaffold;
                @PlaceScaffold.performed += instance.OnPlaceScaffold;
                @PlaceScaffold.canceled += instance.OnPlaceScaffold;
            }
        }
    }
    public GridControlsActions @GridControls => new GridControlsActions(this);
    public interface IGridControlsActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnPlaceScaffold(InputAction.CallbackContext context);
    }
}
