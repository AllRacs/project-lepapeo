
using System;
using LePapeoGenNHibernate.EN.LePapeo;

namespace LePapeoGenNHibernate.CAD.LePapeo
{
public partial interface ICiudadCAD
{
CiudadEN ReadOIDDefault (string nombre
                         );

void ModifyDefault (CiudadEN ciudad);

System.Collections.Generic.IList<CiudadEN> ReadAllDefault (int first, int size);



string New_ (CiudadEN ciudad);

void Modify (CiudadEN ciudad);


void Destroy (string nombre
              );


CiudadEN ReadOID (string nombre
                  );


System.Collections.Generic.IList<CiudadEN> ReadAll (int first, int size);
}
}
