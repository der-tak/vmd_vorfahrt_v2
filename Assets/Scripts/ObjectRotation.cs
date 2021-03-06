using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    private bool openCover;
    private bool openDriverDoor;
    private bool openCoDoor;
    private GameObject driverDoor;
    private GameObject coDriverDoor;
    private GameObject engineCover;
    private Animator coverAnimator;
    private Animator driverDoorAnimator;
    private Animator coDoorAnimator;
    [SerializeField] VehicleScene vehicleCtl;
    [SerializeField] Timer timer;

    private void Awake()
    {
        openCover = false;
        openDriverDoor = false;
        openCoDoor = false;
    }
    private void Start()
    {
        if (vehicleCtl.CheckVehicle() == vehicleCtl.GetAnimModelArrayPos() && vehicleCtl.CheckSide() == 0) //needs cleanup
        {
            engineCover = GameObject.Find("paenomen_engine_cover");
            driverDoor = GameObject.Find("paenomen_driver_door");
            coDriverDoor = GameObject.Find("paenomen_co_driver_door");

            coverAnimator = engineCover.GetComponent<Animator>();
            driverDoorAnimator = driverDoor.GetComponent<Animator>();
            coDoorAnimator = coDriverDoor.GetComponent<Animator>();
        }
    }

    public void ToggleCover()
    {
        timer.ResetTimer();

        if (!openCover)
        {
            coverAnimator.SetBool("open", true);
            openCover = true;
        }
        else
        {
            coverAnimator.SetBool("open", false);
            openCover = false;
        }
    }


    public void ToggleDriverDoor()
    {
        timer.ResetTimer();

        if (!openDriverDoor)
        {
            driverDoorAnimator.SetBool("open", true);
            openDriverDoor = true;
        }
        else
        {
            driverDoorAnimator.SetBool("open", false);
            openDriverDoor = false;
        }
    }
    public void ToggleCoDoor()
    {
        timer.ResetTimer();

        if (!openCoDoor)
        {
            coDoorAnimator.SetBool("open", true);
            openCoDoor = true;
        }
        else
        {
            coDoorAnimator.SetBool("open", false);
            openCoDoor = false;
        }
    }

    public void ToggleOutline(bool toggle)
    {
        engineCover.GetComponent<Outline>().enabled = toggle;
        driverDoor.GetComponent<Outline>().enabled = toggle;
        coDriverDoor.GetComponent<Outline>().enabled = toggle;
    }
}
