# MINUTA DE RELEVAMIENTO

## 1. Introducción
Se lleva a cabo la presente minuta con el objetivo de relevar los requerimientos para el desarrollo de un sistema de gestión de changas o trabajos cortos. Este sistema permitirá que los empleadores publiquen oportunidades laborales de corta duración y que diversos trabajadores puedan postularse a dichas ofertas.

## 2. Usuarios del Sistema
- **Client:** Usuario que puede publicar una changa y que puede postularse a una o varias.
- **SysAdmin:** Usuario que tiene control total del sistema.
- **Moderator:** Usuario que revisa trabajos reportados y decide si los mismos infringen alguna norma de la app y merecen ser eliminados o no.
- **Support:** Usuario de la app que recibe quejas de los clientes y asiste a los mismos via mail.

## 3. Objetivos del Sistema
- Permitir a los clientes publicar changas con detalles como descripción del trabajo, ubicación y requisitos.
- Facilitar la postulación de trabajadores a las ofertas publicadas.
- Implementar un sistema de notificación para alertar a los usuarios sobre sus trabajos publicados o cambios en sus postulaciones a través de correo electrónico.
- Integrar un sistema de calificación para mejorar la confianza entre clientes.
- Brindar herramientas de administración para la gestión de usuarios y ofertas laborales.

## 4. Funcionalidades del Sistema
- **Registro y autenticación de usuarios:** Creación de cuentas para usuarios con información básica (email, nombre de usuario, contraseña, teléfono).
- **Publicación de ofertas laborales:** Los clientes pueden publicar trabajos con detalles como título, categoría, precio, fecha/hora, ubicación y descripción.
- **Postulaciones a trabajos:** Los clientes postulantes pueden postularse a las ofertas activas, y los clientes empleadores pueden aceptar postulaciones.
- **Sistema de calificación:** Los clientes empleadores pueden calificar a los trabajadores, y viceversa, con puntuaciones de 1 a 5 y dejar comentarios.
- **Estado de postulaciones:** Seguimiento de postulaciones con estados definidos (exitoso, pendiente, aceptado, rechazado, cancelado).
- **Administración de quejas:** Los clientes pueden formular quejas por problemas en el sistema y ser atendidos a través de correo electrónico para resolver las mismas.

## 5. Requerimientos Técnicos
- Aplicación web responsiva sin versión móvil nativa.
- Base de datos para almacenamiento de usuarios, trabajos y postulaciones.
- Seguridad en el manejo de datos personales.

## 6. Consideraciones Finales
El sistema busca ser una solución eficiente para conectar empleadores con trabajadores de manera rápida y sencilla, optimizando el proceso de contratación para trabajos de corta duración. Se prevén futuras revisiones para ajustar detalles y validar la viabilidad de los requerimientos.
