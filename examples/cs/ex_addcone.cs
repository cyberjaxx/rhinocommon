﻿using System;

partial class Examples
{
  public static Rhino.Commands.Result AddCone(Rhino.RhinoDoc doc)
  {
    Rhino.Geometry.Plane plane = Rhino.Geometry.Plane.WorldXY;
    double height = 10;
    double radius = 5;
    Rhino.Geometry.Cone cone = new Rhino.Geometry.Cone(plane, height, radius);
    if (cone.IsValid)
    {
      bool cap_bottom = true;
      Rhino.Geometry.Brep cone_brep = cone.ToBrep(cap_bottom);
      if (cone_brep!=null)
      {
        doc.Objects.AddBrep(cone_brep);
        doc.Views.Redraw();
      }
    }
    return Rhino.Commands.Result.Success;
  }
}
