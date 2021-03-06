using UnityEngine;

public class ControlSwitch : MonoBehaviour
{
    [SerializeField] VehicleScene vehicleScene;
    [SerializeField] ObjectRotation objectRotation;

    public void ControlSwitcher()
    {
        GetComponent<ZoomControl>().enabled = vehicleScene.GetShow3D();
        if (vehicleScene.CheckSide() == 0 && vehicleScene.CheckVehicle() == vehicleScene.GetAnimModelArrayPos())
        {
            objectRotation.ToggleOutline(vehicleScene.GetShow3D());
            GetComponent<Clicker>().enabled = vehicleScene.GetShow3D();
        }
    }

    public void SwitchSimpleRotation()
    {
        GetComponent<SimpleRotation>().enabled = !vehicleScene.GetShow3D();
    }

    public void SwitchAdvRotation()
    {
        GetComponent<AdvancedRotation>().enabled = vehicleScene.GetShow3D();
    }
}
