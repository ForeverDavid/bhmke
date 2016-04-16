﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKELib
{
    public enum MKENodeType
    {
        uv=1,//u,v - displacement 
        uvuf,//u,v - displacement and rotation related to u
        uvvf,//u,v - displacement and rotation related to v
        uvufvf//u,v - displacement and rotation related to u , v 
    }
    public enum MKEElementType
    {
        triangle=1,//three node finite element
        quad,//four node finite element
        ltriangle,//four node triangle linear triangle
        quadquad// eight node quad
    }
    public enum MKEPlaneType
    {
        stress=1,//plane stress tyoe
        strain,//plane strain type
    }
}
