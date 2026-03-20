# Ejercicio Introductorio de Programación Orientada a Objetos (C#)

## Sistema de gestión de Biblioteca

### 🎯 Objetivo
Modelar un pequeño sistema de biblioteca utilizando conceptos de orientación a objetos.

### 📋 Consigna
Una biblioteca quiere llevar el control de los libros disponibles, los socios que los retiran y el historial de préstamos.

En pequeños grupos, modelen el sistema, definiendo las clases necesarias y sus relaciones.
No es necesario implementar una app funcional, sino centrarse en el diseño de clases y sus relaciones.

- Realizar un [diagrama de clases](https://es.wikipedia.org/wiki/Diagrama_de_clases)
- Usar [Plant Text](https://www.planttext.com/)

### 🔍 Requisitos mínimos
Deben representar al menos:

- Libro: título, autor, ISBN, año, estado (disponible/prestado).
- Socio: nombre, número de socio, libros prestados.
- Prestamo: libro, socio, fecha de préstamo, fecha de devolución (puede estar vacía si aún no fue devuelto).
- Biblioteca: lista de libros, lista de socios, historial de préstamos.

### 💡 Sugerencias de preguntas disparadoras

- ¿Qué clase se relaciona con cuál?
- ¿Qué atributos son relevantes?
- ¿Qué operaciones básicas debería tener la clase Biblioteca? (por ejemplo: PrestarLibro, DevolverLibro)
- ¿Cómo modelarían la relación entre socios y préstamos?
- ¿Alguna clase puede ser compuesta por otras?