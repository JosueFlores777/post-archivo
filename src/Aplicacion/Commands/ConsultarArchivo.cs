﻿using Dominio.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Commands
{
    public class ConsultarArchivo: IMessage
    {
        public int IdArchivo { get; set; }
    }
}
