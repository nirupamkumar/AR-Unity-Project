using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : DefaultObserverEventHandler
{

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
    }
}
