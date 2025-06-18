# Platita API

## 🔐 Configuración local (`appsettings.json`)

Este proyecto requiere un archivo `.env` con claves de configuración sensibles como JWT y claves de la bd.
Cada vez que se crea una branch hay que crear el .env para que funcione JWT y la bd.

> ⚠️ Por seguridad, **`.env` no está incluido en el repositorio**.  
> Usá el archivo de ejemplo para crear el tuyo localmente.

### ➤ Paso 1: Copiar archivo de ejemplo

En la raíz del proyecto, corré:

```en bash hacer este comando
cp .env-example .env
```

### ➤ Paso 2: Reemplazar las claves de ejemplo por las claves reales
Luego de hacer esto hay que pegar la claves reales en el .env
