# Historias de Usuario

## Historia de Usuario 1: Registro de Usuarios
**Como** usuario del sistema,  
**quiero** registrar mis datos personales en la plataforma,  
**para** poder acceder a las funcionalidades del sitio.

### Criterios de Aceptación:
- El formulario de registro debe contener los campos: nombre, correo electrónico, contraseña y confirmación de contraseña.
- Al hacer clic en el botón "Registrar", los datos deben validarse.
- Mostrar un mensaje de éxito si el registro fue exitoso.

### Criterios de Rechazo:
- Mostrar un mensaje de error si algún campo obligatorio está vacío.
- No permitir contraseñas menores de 6 caracteres.

---

## Historia de Usuario 2: Inicio de Sesión
**Como** usuario registrado,  
**quiero** iniciar sesión con mi correo y contraseña,  
**para** acceder a mi cuenta.

### Criterios de Aceptación:
- Mostrar un formulario de inicio de sesión con los campos de correo y contraseña.
- Redirigir al usuario al dashboard si las credenciales son válidas.
- Mostrar un mensaje de error si las credenciales son incorrectas.

### Criterios de Rechazo:
- No permitir el acceso si algún campo está vacío.
- Mostrar un mensaje de error para correos no registrados.

---

## Historia de Usuario 3: Navegación del Menú Principal
**Como** usuario,  
**quiero** navegar fácilmente por las secciones del sitio web,  
**para** encontrar la información que necesito.

### Criterios de Aceptación:
- El menú principal debe contener las opciones: Inicio, Servicios, Contacto y Perfil.
- Al hacer clic en una opción, la página debe cargar la sección correspondiente.
- Las opciones deben estar visibles y accesibles en la parte superior de la página.

### Criterios de Rechazo:
- No permitir enlaces rotos en las opciones del menú.
- Mostrar un mensaje de error si una sección no está disponible.

---

## Historia de Usuario 4: Prueba Automatizada de Funcionalidad
**Como** desarrollador,  
**quiero** validar automáticamente la funcionalidad de la página de inicio,  
**para** asegurar que el sitio web funcione correctamente.

### Criterios de Aceptación:
- La prueba automatizada debe abrir el navegador y cargar la página de inicio.
- Validar que los elementos principales como el logo y los enlaces del menú estén visibles.
- Capturar una captura de pantalla de la página de inicio.

### Criterios de Rechazo:
- Reportar un error si algún elemento principal está ausente.
- Terminar la prueba si la página no carga en 10 segundos.

---

## Historia de Usuario 5: Generación de Reportes
**Como** administrador del sistema,  
**quiero** generar un reporte de los resultados de las pruebas automatizadas,  
**para** analizar el desempeño del sitio web.

### Criterios de Aceptación:
- El reporte debe incluir el estado (éxito/fallo) de cada prueba.
- Guardar el reporte en formato HTML en la carpeta de resultados.
- Incluir capturas de pantalla de las pruebas fallidas.

### Criterios de Rechazo:
- Mostrar un error si no se puede generar el archivo HTML.
- No generar reportes vacíos si no se ejecutaron pruebas.
