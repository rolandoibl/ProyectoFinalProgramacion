﻿namespace InterfazPago
{
    public interface IMPago
    {
        float Efectivo(float total, float efectivo);
        bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string CSS);
    }
}