# Platita API

## 🔐 Configuración local (`appsettings.json`)

Este proyecto requiere un archivo `appsettings.json` con claves de configuración sensibles como JWT.
Cada vez que se crea una branch hay que crear el appsetting.json para que funcione JWT.

> ⚠️ Por seguridad, **`appsettings.json` no está incluido en el repositorio**.  
> Usá el archivo de ejemplo para crear el tuyo localmente.

### ➤ Paso 1: Copiar archivo de ejemplo

En la raíz del proyecto Web, corré:

```en bash hacer este comando
cp appsettings.example.json appsettings.json
```

### ➤ Paso 2: Reemplazar la clave de ejemplo por la clave real
Luego de hacer esto hay que pegar la clave real en el apartado key del appsettings.json