﻿public interface ICar
{
    string Model { get; }
    string DriverName { get; }

    string BreaksMessage();
    string GasPedalMessage();
}

