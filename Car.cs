using System;

public class Car : Vehicle
{
    public string CarName{get; set;}

    public PetrolEngine petrolengine;

    public ManualTransmission manualTransmission;

    

    public override string Start()
    {
        return string.Format("The car {0}",petrolengine.Start());
    }
    public override string Accelerate()
    {
        return string.Format("The car {0}",petrolengine.Accelerate());
    }

    public override string Stop()
    {
        return string.Format("The car {0}",petrolengine.Stop());
    }

    public virtual string TransmissionType()
    {
        return string.Format("The car is using {0}",manualTransmission.TransmissionType());
    }
}