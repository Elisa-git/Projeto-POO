using System;
using System.Collections.Generic;
using System.Text;

public static class Factory
{
    public static Cliente GetCliente()
    {
        return new Cliente();
    }
}