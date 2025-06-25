# Minuta de Relevamiento – Sistema de Gestión de Changas “Platita”

## 1. Contexto  
La aplicación **“Platita”** surge con el objetivo de facilitar el contacto entre personas que necesitan resolver tareas o trabajos puntuales (“changas”) y trabajadores que estén disponibles para realizarlos. El sistema apunta a formalizar y agilizar estas contrataciones, brindando una plataforma digital que garantice organización, trazabilidad, comunicación, y valoración entre ambas partes.

El uso de la plataforma está orientado principalmente a personas que deseen ofrecer trabajos de corta duración (clientes empleadores) y a quienes buscan ese tipo de trabajos (clientes postulantes). A su vez, se prevé la participación de roles administrativos para mantener el correcto funcionamiento del entorno.

## 2. Proceso Actual  
Actualmente, la contratación informal de changas se realiza principalmente por grupos de redes sociales, mensajes entre conocidos o cartelería en espacios públicos. Este proceso conlleva múltiples dificultades: falta de visibilidad, dificultad para comparar candidatos, ausencia de historial de confiabilidad y complicaciones para resolver conflictos o problemas surgidos durante la ejecución del trabajo.

Tampoco existe una forma eficiente de centralizar reclamos o brindar soporte a quienes utilizan estos canales informales. Esto genera desconfianza y limita las oportunidades de acceso tanto para empleadores como para trabajadores.

## 3. Proceso con el Sistema de Información Deseado  
La plataforma “Platita” permitirá digitalizar y organizar este proceso. Se plantea que los usuarios (clientes) puedan registrarse, ya sea para ofrecer changas o para postularse a las mismas.

Una vez logueados, los usuarios empleadores podrán crear publicaciones especificando:

- Título del trabajo  
- Descripción  
- Categoría  
- Ubicación  
- Fecha y horario deseado

Los demás usuarios podrán postularse a estas changas con un breve mensaje o resumen de su interés. El empleador podrá aceptar o rechazar postulaciones. Una vez finalizada la changa, ambas partes podrán calificarse entre sí para fortalecer la reputación de los usuarios en la plataforma.

El sistema incluirá un panel de administración para que perfiles como **Moderador**, **Support** o **SysAdmin** puedan:

- Gestionar usuarios  
- Atender quejas  
- Controlar publicaciones reportadas por infringir las normas de la comunidad  
- Eliminar contenidos inapropiados  

Además, se incorporará un sistema de notificaciones por correo electrónico para avisar a los usuarios sobre el estado de sus postulaciones, publicaciones o quejas.

## 4. Estados y Flujo de Postulaciones  
Cada changa y postulación puede pasar por los siguientes estados:

- **Pendiente:** postulación activa a un trabajo esperando decision del empleador  
- **Exitoso:** cuando el empleador acepta la postulación  
- **Rechazado:** cuando el empleador selecciona a otro postulante  
- **Cancelado:** por decisión del empleador, del postulante
- **Finalizado:** una vez que el trabajo fue realizado  
 
## 4. Estados y Flujo de Trabajos  
Cada changa y postulación puede pasar por los siguientes estados:

- **Disponible:** publicación activa sin postulantes o esperando decisiones del empleador  
- **Realizado:** cuando uno el postulante realiza el trabajo 
- **Tomado:** cuando el empleador selecciona a un postulante  
- **Cancelado:** por decisión del empleador, del postulante o por moderación  

## 5. Roles del Sistema  

- **Cliente (Usuario general):** puede crear changas o postularse a ellas  
- **SysAdmin:** tiene acceso completo al sistema y puede gestionar cualquier entidad  
- **Moderador:** se encarga de revisar publicaciones o usuarios reportados. Puede eliminar contenido inapropiado  
- **Support:** recibe quejas y asiste a los usuarios por correo electrónico  

## 6. Funcionalidades  

- **Autenticación y registro de usuarios**  
- **Gestión de changas:** creación, edición, eliminación 
- **Postulación a changas**  
- **Evaluación y calificación mutua (1 a 5 estrellas + comentario)**  
- **Vistas de administración para roles de soporte y moderación**  
- **Sistema de notificaciones vía mail sobre cambios relevantes**  
- **Gestión de quejas y soporte al usuario**

## 7. Requerimientos Técnicos  

- Aplicación web responsiva (sin app móvil nativa en esta fase)  
- Backend con base de datos para gestión de usuarios, trabajos, postulaciones y calificaciones  
- Seguridad en el manejo de información personal y autenticación con JWT (JsonWebToken)
- Posible integración futura con servicios de geolocalización o mapas  

## 8. Consideraciones Finales  

El proyecto **“Platita”** busca profesionalizar y dar marco digital a un proceso cotidiano que hoy se encuentra desorganizado y atomizado. Su objetivo es mejorar la confianza entre las partes, fomentar el empleo informal bajo ciertos parámetros de calidad, y ofrecer una experiencia sencilla tanto para quienes buscan ayuda como para quienes ofrecen su tiempo y habilidades.

Se prevén nuevas reuniones para continuar profundizando en aspectos específicos del diseño visual, flujos UX y detalles técnicos de implementación.
