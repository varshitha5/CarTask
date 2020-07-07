using System;

public class ManualTransmission : Transmission
{
    public override string TransmissionType()
    {
        return string.Format("It is a Manual Transmission");
    }
}