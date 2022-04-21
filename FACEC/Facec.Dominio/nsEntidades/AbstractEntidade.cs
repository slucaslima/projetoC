﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.nsEntidades
{
    public abstract class AbstractEntidade
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        public AbstractEntidade()
        {
            Id = Guid.NewGuid();
        }

    }
}
