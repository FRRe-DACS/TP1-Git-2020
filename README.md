# TP1-Git-2020

Modalidad de Desarrollo: Grupal.

Formato de Presentación: Documento digital (formato .odt, .ppt .pdf)  enviado a los correos electrónicos de los profesores de la cátedra.

Fecha de Entrega: 14/04/2020

Exposición Grupal: 17/04/2020

## Actividad 1:	Informe de investigación de Sistema de Control de Versiones
•	Investigar y elaborar un breve informe de sistemas de control de versiones disponibles en el mercado (entre 5 y 8, ejemplo git, mercurial, svn, etc). Indicar los siguientes ítems:

a)	Tipos de versionado soportados.

b)	Licencia

c)	Costo (gratuito / propietario)

d)	Quien lo mantiene.

e)	Plataformas soportadas (Windows, Unix, etc)

f)	Extras


•	Elaborar un cuadro comparativo que resuma los puntos antes mencionados 

•	Realizar el mismo cuadro con plataformas comerciales de sistemas de control de versiones (ejemplo Atlassian, etc) agregando la columna sistemas de control de versiones que soporta mencionadas en el punto anterior.

 ## Actividad 2: Análisis y utilización de un Sistema de Control de Versiones Centralizado
•	Investigar un SCV Centralizado y explicar las principales características brevemente.

•	Enumerar ventajas y desventajas, y comparación con SCV Descentralizados.

•	Seleccionar un servidor que se encuentre en la nube/web gratuito para realizar un ejemplo.

•	Realizar un ejemplo iniciar el repositorio, clonarlo, modificarlo y colaborar en un pequeño equipo por lo menos 2 miembros del grupo.

•	Utilizar de ser necesario una herramienta cliente o IDE.

•	Documentar el ejemplo con capturas de commits de los miembros del equipo sobre un mismo archivo y otro ejemplo de branch y merge. 

## Actividad 3: Actividad práctica sobre Git y Github
•	Utilizando Git por línea de comandos o desde la Web de Github (según corresponda) realizar el siguiente ejercicio (ir evindenciando documentando los pasos ver nota al final):

a)	Un miembro del equipo va a clonar el siguiente repositorio y va a crear una rama para el grupo (la misma va a tener la forma GX/principal donde X es el número de grupo)
https://github.com/FRRe-DACS/TP1-Git-2020.git

b)	En su repositorio local el usuario va a crear un va a crear una carpeta de grupo (grupoX) y dentro de la misma va crear un proyecto de consola en ASP.Net Core. Commitear los cambios en el repositorio y subir la rama al servidor remoto.
Les dejo un link de ayuda:
https://docs.microsoft.com/es-es/dotnet/core/tutorials/with-visual-studio-code?wt.mc_id=personal-blog-chnoring

c)	Una vez creada la rama del grupo en el servidor uno de los miembros del grupo va hacer un fork de la rama. Clona el fork, va a insertar una función que imprime una entrada de pantalla en el programa de consola, commit -> push (sobre el repositorio del fork) y luego crear un pull request al repositorio del grupo a la rama del grupo.

d)	Los demás miembros del grupo: Clonar el repositorio y toman la rama del grupo. A partir de la rama del grupo, crean una rama personal (gXiniciales grupo X e 2 iniciales)  donde realizar una modificación en código (insertar una función que imprima caracteres, que calcule un factorial, que imprima un mensaje en pantalla, que realice una transformación uppercase, etc) y realizar un commit y push, Ponerse de acuerdo en el grupo.

e)	Realizar un pull request de la rama personal a la principal de grupo.

f)	Aceptar / confirmar los pull request en la web, obtener a la funcionalidad completa del programa. Generar un tag para la versión con el nombre gX-V-1.0.0 X nro de grupo (por línea de comando) y subir al repositorio remoto.

g)	Realizar un cambio en el programa sobre la rama principal del grupo y subir el cambio (que introduce un error al programa).

h)	Crear una rama a partir del tag creado y subir la rama al repo remoto y crear un pull request a la rama principal.

i)	Aceptar / Confirmar el pull request creado en el paso anterior (corregir el error).


Nota: La documentación quedará evidenciada mediante un repositorio y capturas en el informe a presentar.
