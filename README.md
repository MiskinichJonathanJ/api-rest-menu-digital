# Menu Digital Restaurante

Este proyecto es parte de la práctica de la materia Proyecto de Software, cuyo objetivo es desarrollar un sistema de menú digital para un restaurante.
El sistema reemplaza la carta física tradicional y permite gestionar de forma digital tanto los platos del menú como las órdenes de los clientes.

## Tecnologías utilizadas

- Lenguaje: C# (.NET 8)
- Framework: ASP.NET Core Web API
- ORM: Entity Framework Core (Code-First)
- Base de Datos: PostgreSQL
- Arquitectura: Hexagonal (Domain-Centric)
- Capas: Domain, Application, Infrastructure, API
- Patrón CQRS aplicado
- Inyección de dependencias en toda la aplicación

## Funcionalidades (Parte 1 completada)

- ✔️ Crear platos (endpoint POST /api/v1/dish)
- ✔️ Listar platos (con filtros por nombre, categoría y orden por precio ASC/DESC)
- ✔️ Actualizar información de un plato (PUT /api/v1/dish/{id})

## Modelo de datos

### El sistema se basa en el siguiente modelo:

- Category: Agrupa platos del menú (Ej: Pastas, Pizzas, Bebidas, etc.)
- Dish: Representa cada plato con su nombre, descripción, precio, imagen y disponibilidad
- DeliveryType: Define si la orden es Delivery, Take Away o Dine In
- Order & OrderItem: Manejo de comandas con relación a platos, notas y cantidades
- Status: Estados de órdenes e ítems (Pending, In Progress, Ready, Delivered, Closed)

## Instalación y ejecución

1. Clonar el repositorio
```bash
git clone https://github.com/tuusuario/MenuDigitalRestaurante.git
cd MenuDigitalRestaurante
```
2. Configurar la cadena de conexión en appsettings.json
```bash
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=menu_db;Username=postgres;Password=tu_password"
}
```
3. Aplicar migraciones y crear la base de datos:
```bash
dotnet ef migrations add [NombreMigracion]   
dotnet ef database update
```
4. Ejecutar el proyecto:
```bash
dotnet run
```
5. Acceder a la documentación de la API con Swagger:
```bash
http://localhost:5000/swagger
``` 

## Endpoints principales (Parte 1)

- GET /api/v1/dishes → Lista todos los platos (con filtros opcionales y ordenamiento).
- POST /api/v1/dishes → Crea un nuevo plato.
- PUT /api/v1/dishes/{id} → Actualiza la información de un plato.

## ✅ Buenas prácticas aplicadas

- Clean Code & Clean Architecture: separación clara de responsabilidades.
- Principios SOLID: servicios desacoplados y fácilmente testeables.
- CQRS: separación de queries (lectura) y commands (escritura).
- Migrations con EF Core para mantener la base versionada.
  
