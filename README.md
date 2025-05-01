# AlgoritmosYProgramacionProyectoIntegrador
- - -
## Consigna
### Proyecto 1:
Una empresa constructora tiene varias obras en ejecución y 8 grupos de obreros que trabajan en las obras. De cada obra se conoce el nombre y dni del propietario, código interno (se lo asigna el sistema), tipo de obra (construcción, remodelación, ampliación, etc.), estado de avance (porcentaje), el jefe de obra y el costo. De cada obrero se almacena su nombre y apellido, dni, nro legajo, sueldo y cargo (capataz, albañil, peón, plomero, electricista, etc.). El jefe de obra es un obrero responsable de una obra por lo cual cobra una bonificación especial a parte de su sueldo y dirige un grupo de obreros que trabajan en dicha obra. De cada grupo de obreros se conoce el código de obra en la que están trabajando (0 en caso de no estar asignado a ninguna obra) y los integrantes.

Se deberá desarrollar una aplicación, utilizando las clases que considere necesarias, utilizando herencia cuando corresponda. La aplicación debe proveer, mediante un menú, las siguientes funcionalidades: 
- a) Contratar un obrero nuevo (se agrega a la empresa y a un grupo)
- b) Eliminar un obrero (se elimina de la empresa y de su grupo)
- c) Contratar a un jefe de obra (se asigna a una obra existente) y se le asocia un grupo de obreros libre. Si no existe ningún grupo libre se debe levantar una excepción que indique lo  sucedido. 
- d) Submenú de impresión: listado de obreros, de obras en ejecución, de obras finalizadas y de jefes, porcentaje de obras de remodelación sin finalizar.
- e) Modificar el estado de avance de una obra. Si el estado de avance llega al 100% la obra debe darse por finalizada, se elimina del listado de obras en ejecución y se guarda en el de obras  finalizadas. 
- f) Dar de baja a un jefe (se elimina de la empresa, se desvincula de la obra y se libera el grupo de obreros asignado
- - -
## Primera Entrega: UML
[Link a Modelo UML (Lucidchart)](https://lucid.app/lucidchart/1852f4cd-064a-4caa-a283-08b204906e18/edit?viewport_loc=-143%2C-81%2C3324%2C1183%2C0_0&invitationId=inv_934e6d0f-0100-4a17-961d-4e7751db7c8d) 
<sub><sup>Nota: para ver en Lucidchart es necesario iniciar sesión. (se puede iniciar sesión con google). </sup></sub>
![Modelo del proyecto 1 en UML](https://raw.githubusercontent.com/cristiangabrielbravo92/AlgoritmosYProgramacionProyectoIntegrador/refs/heads/main/UML%20Proyecto%20Integrador.jpg "Modelo del proyecto 1 en UML")
